using Sulang.Wpf.Common.Dialogs;
using Sulang.Wpf.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sulang.Wpf.Controls.Dialogs
{
    /// <summary>
    /// 对话框服务
    /// </summary>
    public sealed class DialogService : ViewModelService<DialogData>
    {
        /// <summary>
        /// 对话框服务
        /// </summary>
        /// <param name="data"></param>
        public DialogService(DialogData data)
        {
            this.Data = data;
        }

        /// <summary>
        /// 显示
        /// </summary>
        public void Show()
        {
            this.Data.Visibility = Visibility.Visible;
        }
    }
}
