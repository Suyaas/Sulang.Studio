using Sulang.Wpf.Common.Commands;
using Sulang.Wpf.Common.Commands.EventArgs;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sulang.Wpf.Controls.Dialogs
{
    /// <summary>
    /// ContentDialog.xaml 的交互逻辑
    /// </summary>
    public partial class ContentDialog : UserControl
    {

        /// <summary>
        /// 确认事件
        /// </summary>
        public event EventHandler OnConfirm;

        /// <summary>
        /// 取消事件
        /// </summary>
        public event EventHandler OnCancel;

        /// <summary>
        /// 命令事件
        /// </summary>
        public event CommandDelegates.CommandEventHandle OnCommand;

        public ContentDialog()
        {
            InitializeComponent();
            // 内容
            ctlContent.Content = string.Empty;
            // 标题
            Title = "";
            // 可见性
            Visibility = Visibility.Visible;
            Width = 400;
            Height = 200;
            // 确认事件
            this.OnConfirm += (sender, e) => { };
            // 取消事件
            this.OnCancel += (sender, e) => { };
            // 命令事件
            this.OnCommand = (sender, e) =>
            {
                if (Command.CanExecute(CommandParameter))
                {
                    e.Attach = CommandParameter;
                    Command.Execute(e);
                }
            };
        }

        #region Title属性

        // 注册Title属性
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTtilePropertyChanged)));

        // Ttile变更
        static void OnTtilePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContentDialog dialog = (ContentDialog)d;
            dialog.txtTitle.Text = (string)e.NewValue;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set
            {
                SetValue(TitleProperty, value);
                txtTitle.Text = value;
            }
        }

        #endregion

        #region Width属性

        // 注册Title属性
        public new static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(double),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(0d, new PropertyChangedCallback(OnWidthPropertyChanged)));

        // Ttile变更
        static void OnWidthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContentDialog dialog = (ContentDialog)d;
            dialog.gridBox.Width = (double)e.NewValue;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public new double Width
        {
            get => (double)GetValue(WidthProperty);
            set
            {
                SetValue(WidthProperty, value);
                gridBox.Width = value;
            }
        }

        #endregion

        #region Height属性

        // 注册Title属性
        public new static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(nameof(Height), typeof(double),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(0d, new PropertyChangedCallback(OnHeightPropertyChanged)));

        // Ttile变更
        static void OnHeightPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContentDialog dialog = (ContentDialog)d;
            dialog.gridBox.Height = (double)e.NewValue;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public new double Height
        {
            get => (double)GetValue(HeightProperty);
            set
            {
                SetValue(HeightProperty, value);
                gridBox.Height = value;
            }
        }

        #endregion

        #region Content属性

        // 注册内容属性
        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(Visibility.Hidden, new PropertyChangedCallback(OnContentPropertyChanged)));

        // 内容变更
        static void OnContentPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContentDialog dialog = (ContentDialog)d;
            dialog.ctlContent.Content = e.NewValue;
        }

        /// <summary>
        /// 内容
        /// </summary>
        public new object Content { get => GetValue(ContentProperty); set => SetValue(ContentProperty, value); }

        #endregion

        #region Command属性

        // 注册命令属性
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 命令
        /// </summary>
        public ICommand Command { get => (ICommand)GetValue(CommandProperty); set => SetValue(CommandProperty, value); }

        #endregion

        #region CommandParameter属性

        // 注册命令参数属性
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 命令参数
        /// </summary>
        public object CommandParameter { get => GetValue(CommandParameterProperty); set => SetValue(CommandParameterProperty, value); }

        #endregion

        #region Visibility属性

        // 注册Visibility属性
        public new static readonly DependencyProperty VisibilityProperty =
            DependencyProperty.Register("Visibility", typeof(Visibility),
                typeof(ContentDialog),
                new FrameworkPropertyMetadata(Visibility.Hidden, new PropertyChangedCallback(OnVisibilityPropertyChanged)));

        // Visibility变更
        static void OnVisibilityPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContentDialog dialog = (ContentDialog)d;
            dialog.digGrid.Visibility = (Visibility)e.NewValue;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public new Visibility Visibility
        {
            get => (Visibility)GetValue(VisibilityProperty);
            set
            {
                SetValue(VisibilityProperty, value);
            }
        }

        #endregion

        // 确定
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            SetValue(VisibilityProperty, Visibility.Hidden);
            this.OnConfirm(this, new EventArgs());
            this.OnCommand(this, new CommandEventArgs(DialogCommands.Confirm));
        }

        // 取消
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            SetValue(VisibilityProperty, Visibility.Hidden);
            this.OnCancel(this, new EventArgs());
            this.OnCommand(this, new CommandEventArgs(DialogCommands.Cancel));
        }
    }
}
