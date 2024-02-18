using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Common.Entitites
{
    /// <summary>
    /// 唯一数据实体
    /// </summary>
    public abstract class UniqueEntity : NeatEntity
    {
        /// <summary>
        /// 唯一Id
        /// </summary>
        public string UniqueId { get; set; } = string.Empty;
    }
}
