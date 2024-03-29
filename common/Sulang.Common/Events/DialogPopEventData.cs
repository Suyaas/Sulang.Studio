﻿using Sulang.Infrastructure.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Controls.Dialogs
{
    /// <summary>
    /// 对话框弹出事件数据
    /// </summary>
    public abstract class DialogPopEventData : CallbackEventData<bool>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; } = string.Empty;
    }
}
