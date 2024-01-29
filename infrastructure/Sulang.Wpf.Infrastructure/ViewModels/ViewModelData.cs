using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sulang.Wpf.Infrastructure.ViewModels.Dependency;

namespace Sulang.Wpf.Infrastructure.ViewModels
{
    /// <summary>
    /// 视图建模数据
    /// </summary>
    public abstract class ViewModelData : INotifyPropertyChanged, IViewModelData
    {
        // 属性变更事件
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 执行属性变更
        /// </summary>
        /// <param name="propertyName"></param>
        public virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
