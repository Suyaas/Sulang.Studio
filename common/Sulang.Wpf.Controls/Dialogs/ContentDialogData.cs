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
    public sealed class ContentDialogData : DialogData
    {
        #region 标题

        // 标题
        private string _title = string.Empty;

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        #endregion

        #region 宽度

        // 宽度
        private int _width = 400;

        /// <summary>
        /// 宽度
        /// </summary>
        public int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                RaisePropertyChanged(nameof(Width));
            }
        }

        #endregion

        #region 高度

        // 高度
        private int _height = 400;

        /// <summary>
        /// 高度
        /// </summary>
        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                RaisePropertyChanged(nameof(Height));
            }
        }

        #endregion

        #region 内容

        // 内容
        private object _content = string.Empty;

        /// <summary>
        /// 内容
        /// </summary>
        public object Content
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChanged(nameof(Content));
            }
        }

        #endregion
    }
}
