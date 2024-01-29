using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Common.Commands.EventArgs
{
    /// <summary>
    /// 命令事件参数
    /// </summary>
    public sealed class CommandEventArgs : System.EventArgs
    {
        /// <summary>
        /// 命令事件参数
        /// </summary>
        public CommandEventArgs(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 附加属性
        /// </summary>
        public object? Attach { get; set; }
    }
}
