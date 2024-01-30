using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sulang.Infrastructure.Events.Dependency;

namespace Sulang.Infrastructure.Events
{
    /// <summary>
    /// 事件句柄
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public sealed class EventHandle<TData> : IEventHandle<TData>
        where TData : IEventData
    {
        /// <summary>
        /// 事件句柄
        /// </summary>
        public EventHandle(Action<TData>? handle, Func<TData, Task>? handleAsync)
        {
            DataType = typeof(TData);
            Handle = handle;
            HandleAsync = handleAsync;
        }

        /// <summary>
        /// 事件句柄
        /// </summary>
        public Action<TData>? Handle { get; }

        /// <summary>
        /// 异步事件句柄
        /// </summary>
        public Func<TData, Task>? HandleAsync { get; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public Type DataType { get; }
    }
}
