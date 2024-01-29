using Sulang.Wpf.Common.Commands.EventArgs;

namespace Sulang.Wpf.Common.Commands
{
    /// <summary>
    /// 命令委托
    /// </summary>
    public class CommandDelegates
    {
        /// <summary>
        /// 命令事件委托函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void CommandEventHandle(object sender, CommandEventArgs e);
    }
}
