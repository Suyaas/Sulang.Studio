using Suyaa;
using Suyaa.Usables.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sulang.Studio.Dialogs
{
    /// <summary>
    /// About.xaml 的交互逻辑
    /// </summary>
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            var toyAssembly = Use<Assembly>.Toy;
            tbName.Text = toyAssembly.GetProductName();
            tbVersion.Text = $"Version {toyAssembly.GetProductVersion()}";
        }
    }
}
