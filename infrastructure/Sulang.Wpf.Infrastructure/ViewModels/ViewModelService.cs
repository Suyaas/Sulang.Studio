using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sulang.Wpf.Infrastructure.ViewModels.Dependency;

namespace Sulang.Wpf.Infrastructure.ViewModels
{
    /// <summary>
    /// 视图建模服务
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public abstract class ViewModelService<TData> : IViewModelService
        where TData : ViewModelData, new()
    {
        /// <summary>
        /// 视图建模服务
        /// </summary>
        public ViewModelService()
        {
            Data = new TData();
        }

        /// <summary>
        /// 数据
        /// </summary>
        public TData Data { get; }
    }
}
