using Sulang.Wpf.Common.Commands;
using Sulang.Wpf.Common.Commands.EventArgs;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sulang.Studio.Menus
{
    /// <summary>
    /// MainMenu.xaml 的交互逻辑
    /// </summary>
    public partial class MainMenu : UserControl
    {
        /// <summary>
        /// 命令事件
        /// </summary>
        public event CommandDelegates.CommandEventHandle OnCommand;

        /// <summary>
        /// 主菜单
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            // 命令事件
            this.OnCommand += MainMenu_OnCommand;
        }

        // 命令事件触发
        private void MainMenu_OnCommand(object sender, CommandEventArgs e)
        {
            if (Command.CanExecute(CommandParameter))
            {
                e.Attach = CommandParameter;
                Command.Execute(e);
            }
        }

        // 注册Command属性
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand),
                typeof(MainMenu),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        // 支持命令
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // 支持命令参数
        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        // 注册CommandParameter属性
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object),
                typeof(MainMenu),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        // 退出
        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        // 关于
        private void menuAbout_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuAbout"));
        }

        // 保存
        private void menuSave_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuSave"));
        }

        // 另存为
        private void menuSaveAs_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuSaveAs"));
        }

        // 新建
        private void menuNew_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuNew"));
        }

        // 打开
        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuOpen"));
        }

        private void menuPlugs_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuPlugs"));
        }

        private void menuExport_Click(object sender, RoutedEventArgs e)
        {
            this.OnCommand(this, new CommandEventArgs("OnMenuExport"));
        }
    }
}
