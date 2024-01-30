using Suyaa.IocContainer.Kernel;
using Suyaa.IocContainer;
using System.Windows;
using Sulang.Infrastructure.Services.Dependency;
using Sulang.Wpf.Infrastructure.ViewModels.Dependency;
using Sulang.Infrastructure.Events.Dependency;
using Sulang.Infrastructure.Events;

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
            #region 视图相关
            // 注册视图服务
            Ioc<IViewModelService>.Registers(Lifetime.Transient);
            // 注册服务核心类
            Ioc<IServiceCore>.Registers(Lifetime.Transient);
            #endregion
            #region 事件相关
            // 事件
            Ioc<IEventBus>.Register<EventBus>(Lifetime.Singleton);
            #endregion
        }
    }

}
