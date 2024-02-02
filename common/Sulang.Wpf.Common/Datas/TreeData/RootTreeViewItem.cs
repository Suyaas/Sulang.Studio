using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Common.Datas.TreeData
{
    /// <summary>
    /// 根项目
    /// </summary>
    public sealed class RootTreeViewItem : DbTreeViewItem<SchemaTreeViewItem>
    {
        // 拥有图标
        private bool _haveIcon = false;
        /// <summary>
        /// 拥有图标
        /// </summary>
        public bool HaveIcon
        {
            get => _haveIcon; set
            {
                _haveIcon = value;
                RaisePropertyChanged(nameof(HaveIcon));
            }
        }
    }
}
