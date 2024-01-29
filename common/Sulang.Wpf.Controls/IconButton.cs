using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Sulang.Wpf.Controls
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:DbEntityMaker.Controls"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:DbEntityMaker.Controls;assembly=DbEntityMaker.Controls"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:IconButton/>
    ///
    /// </summary>
    public class IconButton : Button
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
            //this.Image = new BitmapImage();
            //this.ImageHover = new BitmapImage();
        }

        #region Image 属性

        // 注册图像属性
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource),
                typeof(IconButton),
                new FrameworkPropertyMetadata(new BitmapImage(), FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 图像
        /// </summary>
        public ImageSource Image { get => (ImageSource)GetValue(ImageProperty); set => SetValue(ImageProperty, value); }

        #endregion

        #region ImageHover 属性

        // 注册悬停图像属性
        public static readonly DependencyProperty ImageHoverProperty =
            DependencyProperty.Register("ImageHover", typeof(ImageSource),
                typeof(IconButton),
                new FrameworkPropertyMetadata(new BitmapImage(), FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 悬停图像
        /// </summary>
        public ImageSource ImageHover { get => (ImageSource)GetValue(ImageHoverProperty); set => SetValue(ImageHoverProperty, value); }

        #endregion

        #region BorderBrushHover 属性

        // 注册悬停边框笔刷属性
        public static readonly DependencyProperty BorderBrushHoverProperty =
            DependencyProperty.Register("BorderBrushHover", typeof(Brush),
                typeof(IconButton),
                new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 悬停边框笔刷
        /// </summary>
        public Brush BorderBrushHover { get => (Brush)GetValue(ImageHoverProperty); set => SetValue(ImageHoverProperty, value); }

        #endregion

        #region BackgroundHover 属性

        // 注册悬停边框笔刷属性
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush),
                typeof(IconButton),
                new FrameworkPropertyMetadata(Brushes.Transparent, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 悬停边框笔刷
        /// </summary>
        public Brush BackgroundHover { get => (Brush)GetValue(BackgroundHoverProperty); set => SetValue(BackgroundHoverProperty, value); }

        #endregion

        #region Text 属性

        // 文本
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string),
                typeof(IconButton),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 文本
        /// </summary>
        public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }

        // 拥有文本
        public static readonly DependencyProperty HaveTextProperty =
            DependencyProperty.Register("HaveText", typeof(bool),
                typeof(IconButton),
                new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.None));

        /// <summary>
        /// 拥有文本
        /// </summary>
        public bool HaveText { get => (bool)GetValue(HaveTextProperty); set => SetValue(HaveTextProperty, value); }

        #endregion
    }
}
