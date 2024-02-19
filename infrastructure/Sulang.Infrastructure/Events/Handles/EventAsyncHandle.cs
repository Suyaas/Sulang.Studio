using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sulang.Infrastructure.Events.Dependency;

namespace Sulang.Infrastructure.Events.Handles
{
    /// <summary>
    /// 事件句柄
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    /// <remarks>
    /// 事件句柄
    /// </remarks>
    /// <remarks>
    /// 事件句柄
    /// </remarks>
    /// <param name="handle"></param>
    public class EventAsyncHandle<TData>(Func<TData, Task>? handle) : IEventHandle<TData, Task>
        where TData : IEventData
    {
        /// <summary>
        /// 事件句柄
        /// </summary>
        public Func<TData, Task> Handle => d =>
        {
            return handle?.Invoke(d) ?? Task.CompletedTask;
        };

        /// <summary>
        /// 数据类型
        /// </summary>
        public Type DataType { get; } = typeof(TData);
    }
}
