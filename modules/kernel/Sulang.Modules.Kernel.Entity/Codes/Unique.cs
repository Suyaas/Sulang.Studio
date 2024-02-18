using Sulang.Common.Entitites;
using Sulang.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Modules.Kernel.Entity.Codes
{
    /// <summary>
    /// 唯一信息
    /// </summary>
    public sealed class Unique : NeatEntity
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        public UniqueDataType DataType { get; set; } = UniqueDataType.Unknow;
        /// <summary>
        /// 数据唯一Id
        /// </summary>
        public string DataId { get; set; } = string.Empty;
    }
}
