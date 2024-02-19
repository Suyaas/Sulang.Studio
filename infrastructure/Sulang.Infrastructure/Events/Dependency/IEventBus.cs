using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Infrastructure.Events.Dependency
{
    /// <summary>
    /// 事件总线
    /// </summary>
    public interface IEventBus
    {
        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        void Trigger<TData>(TData data) where TData : IEventData;
        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        Task TriggerAsync<TData>(TData data) where TData : IEventData;
        /// <summary>
        /// 订阅
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="handle"></param>
        void Subscribe<TData>(Action<TData> handle) where TData : IEventData;
        /// <summary>
        /// 订阅
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="handleAsync"></param>
        void SubscribeAsync<TData>(Func<TData, Task> handleAsync) where TData : IEventData;
    }
}
