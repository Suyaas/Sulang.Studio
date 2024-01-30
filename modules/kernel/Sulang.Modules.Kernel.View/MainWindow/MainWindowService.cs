﻿using Sulang.Native.Win32;
using Sulang.Wpf.Common.Commands;
using Sulang.Wpf.Infrastructure.ViewModels;
using Suyaa;
using Suyaa.Usables.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sulang.Modules.Kernel.View.MainWindow
{
    /// <summary>
    /// 主窗口服务
    /// </summary>
    public sealed class MainWindowService : ViewModelService<MainWindowData>
    {
        /// <summary>
        /// 主窗口服务
        /// </summary>
        public MainWindowService() {
            Data.WindowText = Use<Assembly>.Toy.GetProductFullName();
        }

        /// <summary>
        /// 菜单命令
        /// </summary>
        public RelayCommand OnMenuCommand => new(e => { });

        #region 系统按钮

        private int _lastHeaderMouseUpTick = 0;

        // 设置最大化
        private void SetWindowStateMax()
        {
            Data.WindowState = WindowState.Maximized;
            Data.MaxButtonVisibility = Visibility.Hidden;
            Data.NormalButtonVisibility = Visibility.Visible;
        }

        // 设置最大化
        private void SetWindowStateNormal()
        {
            Data.WindowState = WindowState.Normal;
            Data.MaxButtonVisibility = Visibility.Visible;
            Data.NormalButtonVisibility = Visibility.Hidden;
        }

        /// <summary>
        /// 页面选择命令
        /// </summary>
        public RelayCommand OnWindowHeaderMouseUpCommand => new((e) =>
        {
            // 获取系统双击间隔
            int time = User32.GetDoubleClickTimeSetting();
            int ts = Environment.TickCount - _lastHeaderMouseUpTick;
            if (ts > time)
            {
                _lastHeaderMouseUpTick = Environment.TickCount;
                return;
            }
            _lastHeaderMouseUpTick = 0;
            // 执行最大化和最小化切换
            if (Data.WindowState == WindowState.Normal)
            {
                SetWindowStateMax();
                return;
            }
            SetWindowStateNormal();
        });

        /// <summary>
        /// 最大化
        /// </summary>
        public RelayCommand OnWindowMaxCommand => new((e) =>
        {
            SetWindowStateMax();
        });

        /// <summary>
        /// 还原为普通
        /// </summary>
        public RelayCommand OnWindowNormalCommand => new((e) =>
        {
            SetWindowStateNormal();
        });

        /// <summary>
        /// 还原为普通
        /// </summary>
        public RelayCommand OnWindowMinCommand => new((e) =>
        {
            Data.WindowState = WindowState.Minimized;
        });

        /// <summary>
        /// 窗体关闭
        /// </summary>
        public RelayCommand OnWindowCloseCommand => new((e) =>
        {
            Environment.Exit(0);
        });

        #endregion
    }
}