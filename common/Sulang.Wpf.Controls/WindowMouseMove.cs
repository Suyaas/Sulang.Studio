
using Sulang.Native.Win32;
using Sulang.Wpf.Controls.Helpers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using static Sulang.Native.Win32.User32;

namespace Sulang.Wpf.Controls
{
    /// <summary>
    /// 窗口鼠标移动
    /// </summary>
    public sealed class WindowMouseMove
    {
        private readonly Window _window;
        private DispatcherTimer _timer;
        private bool _isHeaderMouseDown = false;
        private double _left;
        private double _top;
        private POINT _point;

        /// <summary>
        /// 窗口鼠标移动
        /// </summary>
        /// <param name="window"></param>
        public WindowMouseMove(Window window)
        {
            _window = window;
            //Title = Use<Assembly>.Toy.GetProductFullName();
            _timer = new DispatcherTimer();
            //设置的间隔为一分钟，每间隔一分钟就扫描一次要触发执行的事件
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            //Tick触发事件，每隔一分钟扫一次
            _timer.Tick += timer_Tick;
            _timer.IsEnabled = true;
            //在timer_Tick这个方法里就开启定时器开始计时了
            _timer.Start();
        }

        // 计时器
        private void timer_Tick(object? sender, EventArgs e)
        {
            if (!_isHeaderMouseDown) return;
            _timer.Stop();
            var p = GetCurrentCursorPos();
            _window.Move((int)(p.X - _point.X + _left), (int)(p.Y - _point.Y + _top));
            if (!GetAsyncKeyDown(Keys.LButton)) _isHeaderMouseDown = false;
            _timer.Start();
        }

        // 激活
        public void Active()
        {
            _isHeaderMouseDown = true;
            _left = _window.Left;
            _top = _window.Top;
            _point = GetCurrentCursorPos();
        }
    }

}
