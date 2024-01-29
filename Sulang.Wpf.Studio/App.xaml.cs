using Suyaa.IocContainer.Kernel;
using Suyaa.IocContainer;
using System.Windows;
using Sulang.Infrastructure.Services.Dependency;
using Sulang.Wpf.Infrastructure.ViewModels.Dependency;

namespace Sulang.Wpf.Studio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            // 引入视图建模模块
            Ioc.Include(typeof(Modules.Kernel.View.ModuleStartup).Assembly);
            // 注册视图服务
            Ioc<IViewModelService>.Registers(Lifetime.Transient);
            // 注册服务核心类
            Ioc<IServiceCore>.Registers(Lifetime.Transient);
        }
    }

}
