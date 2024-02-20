using Sulang.Infrastructure.Events;
using Sulang.Infrastructure.Events.Datas;
using Sulang.Wpf.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Modules.Kernel.Core.MainWindow.Events
{
    /// <summary>
    /// 关于对话框弹出事件数据
    /// </summary>
    public sealed class AboutDialogPopEventData : PageDialogPopEventData
    {
        /// <summary>
        /// 关于对话框事件数据
        /// </summary>
        /// <param name="callback"></param>
        public AboutDialogPopEventData(Action<bool>? callback)
        {
            this.Callback = callback;
            this.Url = "pack://application:,,,/Sulang.Modules.Kernel.View;component/About/AboutPage.xaml";
            this.Width = 400;
            this.Height = 200;
            this.Title = "关于 ...";
        }
    }
}
