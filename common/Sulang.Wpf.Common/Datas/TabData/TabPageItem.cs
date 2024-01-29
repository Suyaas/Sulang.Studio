using Sulang.Wpf.Infrastructure.ViewModels;

namespace Sulang.Wpf.Common.Datas.TabData
{
    /// <summary>
    /// TabControl建模
    /// </summary>
    public class TabPageItem : ViewModelData
    {
        /// <summary>
        /// TabControl建模
        /// </summary>
        /// <param name="name"></param>
        public TabPageItem(string name)
        {
            Name = name;
        }

        #region 是否支持关闭
        // 是否支持关闭
        private bool _closable = false;
        /// <summary>
        /// 是否支持关闭
        /// </summary>
        public bool Closable
        {
            get => _closable;
            set
            {
                _closable = value;
                RaisePropertyChanged(nameof(Closable));
            }
        }
        #endregion

        #region 标题
        private string _header = string.Empty;
        /// <summary>
        /// 标题
        /// </summary>
        public string Header
        {
            get => _header;
            set
            {
                _header = value;
                RaisePropertyChanged(nameof(Header));
            }
        }
        #endregion

        /// <summary>
        /// 内容
        /// </summary>
        public object? Content { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 转为字符串表示
        /// </summary>
        /// <returns></returns>
        public new string ToString() => Header;
    }
}
