using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Infrastructure.Events.Dependency
{
    /// <summary>
    /// 事件订阅
    /// </summary>
    public interface IEventHandle
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        Type DataType { get; }
    }

    /// <summary>
    /// 事件订阅
    /// </summary>
    public interface IEventHandle<TData> : IEventHandle
        where TData : IEventData
    {
        /// <summary>
        /// 处理句柄
        /// </summary>
        Action<TData>? Handle { get; }

        /// <summary>
        /// 处理句柄
        /// </summary>
        Func<TData, Task>? HandleAsync { get; }
    }
}
