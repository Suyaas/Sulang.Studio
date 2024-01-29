using Sulang.Native.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sulang.Wpf.Controls.Helpers
{
    /// <summary>
    /// 窗口助手
    /// </summary>
    public static class WindowHelper
    {
        /// <summary>
        /// 移动窗口位置
        /// </summary>
        /// <param name="window"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Move(this Window window, int x, int y)
        {
            var wih = new System.Windows.Interop.WindowInteropHelper(window);
            var hWnd = wih.Handle;
            User32.MoveWindow(hWnd, x, y, (int)window.Width, (int)window.Height, false);
        }
    }
}
