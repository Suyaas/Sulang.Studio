using Sulang.Infrastructure.Events.Dependency;

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
            _handles.Add(new EventHandle<T>(handle, null));
        }

        /// <summary>
        /// 订阅异步
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handleAsync"></param>
        /// <returns></returns>
        public void SubscribeAsync<T>(Func<T, Task> handleAsync) where T : IEventData
        {
            _handles.Add(new EventHandle<T>(null, handleAsync));
        }

        /// <summary>
        /// 触发
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public void Trigger<T>(T data) where T : IEventData
        {
            var type = typeof(T);
            var handles = _handles.Where(d => d.DataType == type).ToList();
            foreach (var handle in handles)
            {
                var dataHandle = (IEventHandle<T>)handle;
                if (dataHandle.Handle != null) dataHandle.Handle(data);
                if (dataHandle.HandleAsync != null) dataHandle.HandleAsync(data).GetAwaiter().GetResult();
            }
        }

        /// <summary>
        /// 异步触发
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task TriggerAsync<T>(T data) where T : IEventData
        {
            var type = typeof(T);
            var handles = _handles.Where(d => d.DataType == type).ToList();
            foreach (var handle in handles)
            {
                var dataHandle = (IEventHandle<T>)handle;
                if (dataHandle.Handle != null) dataHandle.Handle(data);
                if (dataHandle.HandleAsync != null) await dataHandle.HandleAsync(data);
            }
        }
    }
}
