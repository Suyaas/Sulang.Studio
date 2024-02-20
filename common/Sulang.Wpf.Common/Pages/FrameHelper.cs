using Sulang.Wpf.Common.Pages.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sulang.Wpf.Common.Pages
{
    /// <summary>
    /// Frame助手
    /// </summary>
    public static class FrameHelper
    {
        /// <summary>
        /// 使用动态页创建一个Frame对象
        /// </summary>
        /// <param name="url"></param>
        /// <param name="extraData"></param>
        /// <returns></returns>
        public static Frame CreateFromDynamicPage(string url, object? extraData)
        {
            // 新建一个新的框架
            var fm = new Frame
            {
                Source = new Uri(url, UriKind.Absolute)
            };
            fm.LoadCompleted += (sender, e) =>
            {
                if (e.Content is IDynamicPage page)
                {
                    page.SetExtraData(extraData);
                }
            };
            return fm;
        }
    }
}
