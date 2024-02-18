using Sulang.Common.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Modules.Kernel.Entity.Codes
{
    /// <summary>
    /// 定义
    /// </summary>
    public sealed class Define : UniqueEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// 注释
        /// </summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>
        /// 父定义Id
        /// </summary>
        public string ParentDefineId { get; set; } = string.Empty;
    }
}
