using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sulang.Infrastructure.Events.Datas;
using Sulang.Infrastructure.Events.Dependency;

namespace Sulang.Infrastructure.Events
{
    /// <summary>
    /// 事件数据
    /// </summary>
    public abstract class CallbackEventData : EventData
    {
        /// <summary>
        /// 回调函数
        /// </summary>
        public Action? Callback { get; protected set; }
    }

    /// <summary>
    /// 事件数据
    /// </summary>
    public abstract class CallbackEventData<T> : EventData
    {
        /// <summary>
        /// 回调函数
        /// </summary>
        public Action<T>? Callback { get; protected set; }
    }
}
