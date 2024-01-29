
using Sulang.Native.Win32;
using Sulang.Wpf.Controls.Helpers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using static Sulang.Native.Win32.User32;

namespace Sulang.Wpf.Controls
{
    /// <summary>
    /// ��������ƶ�
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
        /// ��������ƶ�
        /// </summary>
        /// <param name="window"></param>
        public WindowMouseMove(Window window)
        {
            _window = window;
            //Title = Use<Assembly>.Toy.GetProductFullName();
            _timer = new DispatcherTimer();
            //���õļ��Ϊһ���ӣ�ÿ���һ���Ӿ�ɨ��һ��Ҫ����ִ�е��¼�
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            //Tick�����¼���ÿ��һ����ɨһ��
            _timer.Tick += timer_Tick;
            _timer.IsEnabled = true;
            //��timer_Tick���������Ϳ�����ʱ����ʼ��ʱ��
            _timer.Start();
        }

        // ��ʱ��
        private void timer_Tick(object? sender, EventArgs e)
        {
            if (!_isHeaderMouseDown) return;
            _timer.Stop();
            var p = GetCurrentCursorPos();
            _window.Move((int)(p.X - _point.X + _left), (int)(p.Y - _point.Y + _top));
            if (!GetAsyncKeyDown(Keys.LButton)) _isHeaderMouseDown = false;
            _timer.Start();
        }

        // ����
        public void Active()
        {
            _isHeaderMouseDown = true;
            _left = _window.Left;
            _top = _window.Top;
            _point = GetCurrentCursorPos();
        }
    }

}
