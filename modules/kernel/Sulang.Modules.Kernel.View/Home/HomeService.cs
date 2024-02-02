using Sulang.Infrastructure.Events.Dependency;
using Sulang.Modules.Kernel.Core.Home.Events;
using Sulang.Wpf.Common.Commands;
using Sulang.Wpf.Common.Datas.TabData;
using Sulang.Wpf.Common.Datas.TreeData;
using Sulang.Wpf.Common.Pages.Dependency;
using Sulang.Wpf.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sulang.Modules.Kernel.View.Home
{
    /// <summary>
    /// 主页服务
    /// </summary>
    public sealed class HomeService : ViewModelService<HomeData>
    {
        #region 依赖注入

        private readonly IEventBus _eventBus;

        /// <summary>
        /// 主页服务
        /// </summary>
        public HomeService(
            IEventBus eventBus
            )
        {
            _eventBus = eventBus;
            // 注册打开页面
            _eventBus.Subscribe<PageOpenEventData>(e =>
            {
                OpenPage(e.Name, e.Title, e.Url, true, e.ExtraData);
            });
        }

        #endregion

        #region Tab页相关

        // 关闭所有可关闭页面
        private void CloseAllClosablePage()
        {
            for (int i = Data.Pages.Count - 1; i >= 0; i--)
            {
                var page = Data.Pages[i];
                if (page.Closable) Data.Pages.RemoveAt(i);
            }
            Data.PageIndex = Data.Pages.Count - 1;
        }

        /// <summary>
        /// 页面关闭事件
        /// </summary>
        public RelayCommand OnPageCloseCommand => new((e) =>
        {
            if (e.Attach is not string name) return;
            int pageIndex = Data.PageIndex;
            // 页面存在，则执行切换
            for (int i = 0; i < Data.Pages.Count; i++)
            {
                if (Data.Pages[i].Name == name)
                {
                    Data.Pages.RemoveAt(i);
                    if (pageIndex == i) Data.PageIndex = pageIndex - 1;
                    return;
                }
            }
        });

        // 打开页面
        private TabPageItem OpenPage(string name, string header, string url, bool closable, object? extraData)
        {
            // 页面存在，则执行切换
            for (int i = 0; i < Data.Pages.Count; i++)
            {
                if (Data.Pages[i].Name == name)
                {
                    Data.PageIndex = i;
                    return Data.Pages[i];
                }
            }
            // 不存在则执行新建
            var fm = new Frame
            {
                Source = new Uri(url, UriKind.Relative)
            };
            fm.LoadCompleted += (sender, e) =>
            {
                var page = (IDynamicPage)e.Content;
                page.SetExtraData(extraData);
            };
            var page = new TabPageItem(name)
            {
                Header = header,
                Content = fm,
                Closable = closable,
            };
            Data.Pages.Add(page);
            Data.PageIndex = Data.Pages.Count - 1;
            return page;
            //UpdatePageSelected();
        }

        #endregion
    }
}
