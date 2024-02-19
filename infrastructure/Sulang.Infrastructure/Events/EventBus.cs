using Sulang.Infrastructure.Events.Dependency;
using Sulang.Infrastructure.Events.Handles;

namespace Sulang.Infrastructure.Events
{
    /// <summary>
    /// 事件总线
    /// </summary>
    public sealed class EventBus : IEventBus
    {
        private readonly List<IEventHandle> _handles;

        /// <summary>
        /// 事件总线
        /// </summary>
        public EventBus()
        {
            _handles = [];
        }

        /// <summary>
        /// 订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handle"></param>
        public void Subscribe<T>(Action<T> handle) where T : IEventData
        {
            _handles.Add(new EventHandle<T>(handle));
        }

        /// <summary>
        /// 异步订阅
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handleAsync"></param>
        /// <returns></returns>
        public void SubscribeAsync<T>(Func<T, Task> handleAsync) where T : IEventData
        {
            _handles.Add(new EventAsyncHandle<T>(handleAsync));
        }

        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        public void Trigger<TData>(TData data) where TData : IEventData
        {
            var type = typeof(TData);
            var handles = _handles.Where(d => d.DataType == type).ToList();
            foreach (var handle in handles)
            {
                if (handle is IEventHandle<TData, bool> dataHandle)
                {
                    if (dataHandle.Handle is null) continue;
                    _ = dataHandle.Handle(data);
                }
                if (handle is IEventHandle<TData, Task> dataAsyncHandle)
                {
                    if (dataAsyncHandle.Handle is null) continue;
                    dataAsyncHandle.Handle(data).GetAwaiter().GetResult();
                }
            }
        }

        /// <summary>
        /// 异步触发
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task TriggerAsync<TData>(TData data) where TData : IEventData
        {
            var type = typeof(TData);
            var handles = _handles.Where(d => d.DataType == type).ToList();
            foreach (var handle in handles)
            {
                if (handle is IEventHandle<TData, bool> dataHandle)
                {
                    if (dataHandle.Handle is null) continue;
                    _ = dataHandle.Handle(data);
                }
                if (handle is IEventHandle<TData, Task> dataAsyncHandle)
                {
                    if (dataAsyncHandle.Handle is null) continue;
                    await dataAsyncHandle.Handle(data);
                }
            }
        }
    }
}
