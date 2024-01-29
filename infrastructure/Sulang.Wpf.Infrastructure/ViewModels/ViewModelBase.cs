using Suyaa.IocContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Infrastructure.ViewModels
{
    /// <summary>
    /// 简洁的视图建模
    /// </summary>
    public abstract class ViewModelBase<TService, TData> : ViewModelData
        where TService : ViewModelService<TData>
        where TData : ViewModelData, new()
    {

        // 服务
        private TService? _service;

        /// <summary>
        /// 服务
        /// </summary>
        public TService Service => _service ??= Ioc<TService>.ResolveRequired();

        /// <summary>
        /// 数据
        /// </summary>
        public TData Data => Service.Data;
    }
}
