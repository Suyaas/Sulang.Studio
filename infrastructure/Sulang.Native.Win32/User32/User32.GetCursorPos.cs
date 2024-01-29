using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Native.Win32
{
    // GetCursorPos
    public static partial class User32
    {
        /// <summary>
        /// 获取光标位置
        /// </summary>
        /// <param name="lpPoint"></param>
        /// <returns></returns>
        [DllImport(Libraries.User32)]
        private static extern bool GetCursorPos(out POINT lpPoint);

        /// <summary>
        /// 获取系统光标位置
        /// </summary>
        /// <returns></returns>
        public static POINT GetCurrentCursorPos()
        {
            if (GetCursorPos(out POINT p))
            {
                return p;
            }
            return new POINT();
        }
    }
}
