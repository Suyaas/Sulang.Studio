using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sulang.Native.Win32
{
    // GetAsyncKeyState
    public static partial class User32
    {
        /// <summary>
        /// 获取键值
        /// </summary>
        /// <param name="vkey"></param>
        /// <returns></returns>
        [DllImport(Libraries.User32)]
        public static extern short GetAsyncKeyState(int vkey);

        /// <summary>
        /// 判断键是否被按下
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetAsyncKeyDown(Keys key)
        {
            var state = GetAsyncKeyState((int)key) & 0x8000;
            return state > 0;
        }
    }
}
