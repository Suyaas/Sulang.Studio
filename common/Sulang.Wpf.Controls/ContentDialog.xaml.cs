using System.Windows;
using System.Windows.Controls;

namespace Sulang.Wpf.Controls
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
            this.OnConfirm(this, new EventArgs());
            SetValue(VisibilityProperty, Visibility.Hidden);
        }

        // 取消
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            SetValue(VisibilityProperty, Visibility.Hidden);
        }
    }
}
