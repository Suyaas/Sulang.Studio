using Sulang.Infrastructure.Events;

namespace Sulang.Modules.Kernel.Core.Home.Events
{
    /// <summary>
    /// 页面打开事件
    /// </summary>
    public sealed class PageOpenEventData(string name, string title, string url, object? extraData) : EventData
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; } = name;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; } = title;
        /// <summary>
        /// 地址
        /// </summary>
        public string Url { get; } = url;
        /// <summary>
        /// 附加数据
        /// </summary>
        public object? ExtraData { get; } = extraData;
    }
}
