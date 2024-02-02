using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Common.Datas.TreeData
{
    /// <summary>
    /// 表项目
    /// </summary>
    public sealed class TableTreeViewItem : DbTreeViewItem
    {
        /// <summary>
        /// Schema
        /// </summary>
        public string Schema { get; set; } = string.Empty;
    }
}
