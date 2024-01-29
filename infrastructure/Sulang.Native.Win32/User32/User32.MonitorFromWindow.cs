using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Native.Win32
{
    // MonitorFromWindow
    public static partial class User32
    {
        /// <summary>
        /// 获取键值
        /// </summary>
        /// <param name="vkey"></param>
        /// <returns></returns>
        [DllImport(Libraries.User32)]
        public static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);
    }
}
