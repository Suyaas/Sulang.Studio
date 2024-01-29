using Sulang.Wpf.Common.Commands.EventArgs;
using System.Windows.Input;

namespace Sulang.Wpf.Common.Commands
{
    /// <summary>
    /// 传递命令
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action<CommandEventArgs> _action;

        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// 传递命令
        /// </summary>
        /// <param name="action"></param>
        public RelayCommand(Action<CommandEventArgs> action)
        {
            _action = action;
        }

        // 是否可执行
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            if (parameter is CommandEventArgs e)
            {
                _action(e);
                return;
            }
            _action(new CommandEventArgs(string.Empty) { Attach = parameter });
        }

        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="action"></param>
        public static explicit operator RelayCommand(Action<CommandEventArgs> action)
        {
            return new RelayCommand(action);
        }
    }
}
