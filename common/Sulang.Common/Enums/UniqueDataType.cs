using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Common.Enums
{
    /// <summary>
    /// 唯一数据类型
    /// </summary>
    [Description("唯一数据类型")]
    public enum UniqueDataType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknow = 0,
        /// <summary>
        /// 定义
        /// </summary>
        [Description("定义")]
        Define = 0x10,
        /// <summary>
        /// 命令
        /// </summary>
        [Description("命令")]
        Command = 0x20,
        /// <summary>
        /// 方法
        /// </summary>
        [Description("方法")]
        Method = 0x30,
    }
}
