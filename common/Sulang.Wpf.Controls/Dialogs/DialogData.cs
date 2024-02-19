using Sulang.Wpf.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sulang.Wpf.Common.Dialogs
{
    /// <summary>
    /// 对话框数据
    /// </summary>
    public sealed class DialogData : ViewModelData
    {
        #region 可见性

        // 可见性
        private Visibility _visibility = Visibility.Hidden;

        /// <summary>
        /// 可见性
        /// </summary>
        public Visibility Visibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                RaisePropertyChanged(nameof(Visibility));
            }
        }

        #endregion
    }
}
