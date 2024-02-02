using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Wpf.Common.Pages.Dependency
{
    /// <summary>
    /// 动态页面
    /// </summary>
    public interface IDynamicPage
    {
        /// <summary>
        /// 设置附加数据
        /// </summary>
        /// <param name="data"></param>
        void SetExtraData(object? data);
    }
}
