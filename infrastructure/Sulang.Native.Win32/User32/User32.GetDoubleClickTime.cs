using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Native.Win32
{
    // GetDoubleClickTime
    public static partial class User32
    {
        /// <summary>
        /// 获取系统双击间隔
        /// </summary>
        /// <returns></returns>
        [LibraryImport(Libraries.User32)]
        private static partial uint GetDoubleClickTime();

        /// <summary>
        /// 获取系统双击间隔
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetDoubleClickTimeSetting()
        {
            return (int)GetDoubleClickTime();
        }
    }
}
