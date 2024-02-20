using Sulang.Wpf.Common.Datas.TabData;
using Sulang.Wpf.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Modules.Kernel.View.About
{
    /// <summary>
    /// 关于数据
    /// </summary>
    public sealed class AboutData : ViewModelData
    {
        #region 程序名称

        // 程序名称
        private string _proName = string.Empty;

        /// <summary>
        /// 程序名称
        /// </summary>
        public string ProName
        {
            get => _proName;
            set
            {
                _proName = value;
                RaisePropertyChanged(nameof(ProName));
            }
        }

        #endregion

        #region 程序版本

        // 程序版本
        private string _proVersion = string.Empty;

        /// <summary>
        /// 程序版本
        /// </summary>
        public string ProVersion
        {
            get => _proVersion;
            set
            {
                _proVersion = value;
                RaisePropertyChanged(nameof(ProVersion));
            }
        }

        #endregion
    }
}
