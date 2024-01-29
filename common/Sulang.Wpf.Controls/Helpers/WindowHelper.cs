using Sulang.Native.Win32;
using Sulang.Wpf.Controls.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

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
            var wih = new WindowInteropHelper(window);
            var hWnd = wih.Handle;
            User32.MoveWindow(hWnd, x, y, (int)window.Width, (int)window.Height, false);
        }

        /// <summary>
        /// 修复全屏占用
        /// </summary>
        /// <param name="window"></param>
        public static void RepairFullScreenBehavior(this Window window)
        {
            if (window == null)
            {
                return;
            }

            if (window.WindowState == WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
                window.Loaded += delegate { window.WindowState = WindowState.Maximized; };
            }

            window.SourceInitialized += delegate
            {
                var wih = new WindowInteropHelper(window);
                IntPtr handle = wih.Handle;
                HwndSource source = HwndSource.FromHwnd(handle);
                if (source != null)
                {
                    //source.AddHook(WindowProc);
                    source.AddHook(WindowProcHandle.WindowProc);
                }
            };
        }
    }
}
