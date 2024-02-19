using Sulang.Wpf.Common.Datas.TabData;
using Sulang.Wpf.Common.Dialogs;
using Sulang.Wpf.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sulang.Modules.Kernel.View.MainWindow
{
    /// <summary>
    /// 主窗口数据
    /// </summary>
    public sealed class MainWindowData : ViewModelData
    {
        /// <summary>
        /// 主窗口数据
        /// </summary>
        public MainWindowData()
        {
            Pages = [];
            AboutDialog = new DialogData();
        }

        #region 对话框

        /// <summary>
        /// 关于对话框
        /// </summary>
        public DialogData AboutDialog { get; }

        #endregion

        #region 窗口

        // 窗口标题
        private string _windowText = string.Empty;

        /// <summary>
        /// 窗口标题
        /// </summary>
        public string WindowText
        {
            get => _windowText;
            set
            {
                _windowText = value;
                RaisePropertyChanged(nameof(WindowText));
            }
        }

        // 窗口状态
        private WindowState _windowState = WindowState.Normal;

        /// <summary>
        /// 窗口状态
        /// </summary>
        public WindowState WindowState
        {
            get => _windowState;
            set
            {
                _windowState = value;
                RaisePropertyChanged(nameof(WindowState));
            }
        }

        // 最大化按钮显示状态
        private Visibility _maxButtonVisibility = Visibility.Visible;

        /// <summary>
        /// 最大化按钮显示状态
        /// </summary>
        public Visibility MaxButtonVisibility
        {
            get => _maxButtonVisibility;
            set
            {
                _maxButtonVisibility = value;
                RaisePropertyChanged(nameof(MaxButtonVisibility));
            }
        }

        // 还原按钮显示状态
        private Visibility _normalButtonVisibility = Visibility.Hidden;

        /// <summary>
        /// 还原按钮显示状态
        /// </summary>
        public Visibility NormalButtonVisibility
        {
            get => _normalButtonVisibility;
            set
            {
                _normalButtonVisibility = value;
                RaisePropertyChanged(nameof(NormalButtonVisibility));
            }
        }

        #endregion

        #region 状态
        // 状态
        private string _status = string.Empty;

        /// <summary>
        /// 状态
        /// </summary>
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                RaisePropertyChanged(nameof(Status));
            }
        }
        #endregion

        #region 页面相关

        // 页面索引
        private int _pageIndex = -1;

        /// <summary>
        /// 页面索引
        /// </summary>
        public int PageIndex
        {
            get => _pageIndex;
            set
            {
                _pageIndex = value;
                RaisePropertyChanged(nameof(PageIndex));
            }
        }

        /// <summary>
        /// 页面集合
        /// </summary>
        public ObservableCollection<TabPageItem> Pages { get; }

        #endregion
    }
}
