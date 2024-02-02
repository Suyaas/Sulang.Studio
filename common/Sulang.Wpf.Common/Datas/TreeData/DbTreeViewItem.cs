using Sulang.Wpf.Infrastructure.ViewModels;
using System.Collections.ObjectModel;

namespace Sulang.Wpf.Common.Datas.TreeData
{
    /// <summary>
    /// 数据库树形列表项
    /// </summary>
    public class DbTreeViewItem : ViewModelData
    {
        /// <summary>
        /// 唯一Id
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        // 是否选中
        private bool _isSelected = false;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                RaisePropertyChanged(nameof(IsSelected));
            }
        }

        // 文本
        private string _text = string.Empty;
        /// <summary>
        /// 文本
        /// </summary>
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                RaisePropertyChanged(nameof(Text));
            }
        }

        // 文本
        private string _description = string.Empty;
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }
    }

    /// <summary>
    /// 数据库树形列表项
    /// </summary>
    public class DbTreeViewItem<T> : DbTreeViewItem
        where T : DbTreeViewItem
    {
        /// <summary>
        /// 数据库树形列表项
        /// </summary>
        public DbTreeViewItem()
        {
            Items = new ObservableCollection<T>();
        }

        /// <summary>
        /// 子项
        /// </summary>
        public ObservableCollection<T> Items { get; }
    }
}
