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
    public sealed class DialogService<T> : ViewModelService<T>
        where T : DialogData, new()
    {
        /// <summary>
        /// 对话框服务
        /// </summary>
        /// <param name="data"></param>
        public DialogService(T data)
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
