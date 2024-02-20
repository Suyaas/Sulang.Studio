using Sulang.Infrastructure.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Controls.Dialogs
{
    /// <summary>
    /// 内容对话框弹出事件数据
    /// </summary>
    public abstract class ContentDialogPopEventData : DialogPopEventData
    {
        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get; set; }
    }
}
