using Sulang.Wpf.Infrastructure.ViewModels;
using Suyaa;
using Suyaa.Usables.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sulang.Modules.Kernel.View.About
{
    /// <summary>
    /// 关于服务
    /// </summary>
    public sealed class AboutService : ViewModelService<AboutData>
    {
        /// <summary>
        /// 关于服务
        /// </summary>
        public AboutService()
        {
            var toyAssembly = Use<Assembly>.Toy;
            Data.ProName = toyAssembly.GetProductName();
            Data.ProVersion = $"Version {toyAssembly.GetProductVersion()}";
        }
    }
}
