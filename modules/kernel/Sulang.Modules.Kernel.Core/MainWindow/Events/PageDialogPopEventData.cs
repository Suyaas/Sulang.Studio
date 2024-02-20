using Sulang.Wpf.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Modules.Kernel.Core.MainWindow.Events
{
    /// <summary>
    /// 页面对话框弹出事件数据
    /// </summary>
    public abstract class PageDialogPopEventData : ContentDialogPopEventData
    {
        /// <summary>
        /// 页面地址
        /// </summary>
        public string Url { get; set; } = string.Empty;
    }
}
