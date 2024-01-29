using Sulang.Wpf.Controls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sulang.Wpf.Studio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WindowMouseMove _windowMouseMove;

        public MainWindow()
        {
            InitializeComponent();
            _windowMouseMove = new WindowMouseMove(this);
        }

        private void header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _windowMouseMove.Active();
        }
    }
}