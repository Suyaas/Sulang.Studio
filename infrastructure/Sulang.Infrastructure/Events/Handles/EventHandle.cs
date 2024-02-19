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
    public class EventHandle<TData>(Action<TData>? handle) : IEventHandle<TData, bool>
        where TData : IEventData
    {

        /// <summary>
        /// 事件句柄
        /// </summary>
        public Func<TData, bool> Handle => d =>
        {
            handle?.Invoke(d);
            return true;
        };

        /// <summary>
        /// 数据类型
        /// </summary>
        public Type DataType { get; } = typeof(TData);
    }
}
