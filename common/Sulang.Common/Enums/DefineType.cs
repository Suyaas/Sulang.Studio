using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Common.Enums
{
    /// <summary>
    /// 定义类型
    /// </summary>
    [Description("定义类型")]
    public enum DefineType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        Unknow = 0,
        /// <summary>
        /// 分类
        /// </summary>
        [Description("分类")]
        Catalog = 0x10,
        /// <summary>
        /// 类
        /// </summary>
        [Description("类")]
        Class = 0x20,
        /// <summary>
        /// 方法
        /// </summary>
        [Description("方法")]
        Method = 0x30,
    }
}
