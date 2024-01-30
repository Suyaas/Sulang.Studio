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
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        void Trigger<T>(T data) where T : IEventData;
        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        Task TriggerAsync<T>(T data) where T : IEventData;
        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handle"></param>
        void Subscribe<T>(Action<T> handle) where T : IEventData;
        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handleAsync"></param>
        void SubscribeAsync<T>(Func<T, Task> handleAsync) where T : IEventData;
    }
}
