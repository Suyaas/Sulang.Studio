using Sulang.Wpf.Common.Datas.TabData;
using Sulang.Wpf.Common.Datas.TreeData;
using Sulang.Wpf.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Modules.Kernel.View.Home
{
    /// <summary>
    /// 主页数据
    /// </summary>
    public sealed class HomeData : ViewModelData
    {
        /// <summary>
        /// 主页数据
        /// </summary>
        public HomeData()
        {
            TreeViewRootItem = new RootTreeViewItem()
            {
                Id = "root",
                Name = "[ROOT]",
                Text = "项目 未命名",
                Description = "项目 未命名",
            };
            TreeViewItems = [TreeViewRootItem];
            Pages = [];
        }

        #region 树形目录项

        /// <summary>
        /// 树形目录根项目
        /// </summary>
        public RootTreeViewItem TreeViewRootItem { get; }

        /// <summary>
        /// 树形目录项
        /// </summary>
        public ObservableCollection<RootTreeViewItem> TreeViewItems { get; }

        #endregion

        #region 页面相关

        // 页面索引
        private int _pageIndex = -1;

        /// <summary>
        /// 页面索引
        /// </summary>
        public int PageIndex
        {
            get => _pageIndex;
            set
            {
                _pageIndex = value;
                RaisePropertyChanged(nameof(PageIndex));
            }
        }

        /// <summary>
        /// 页面集合
        /// </summary>
        public ObservableCollection<TabPageItem> Pages { get; }

        #endregion
    }
}
