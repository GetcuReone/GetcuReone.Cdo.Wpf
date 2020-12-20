using GetcuReone.Cdo.Wpf.UiNotification.Entities;
using GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow;
using GetcuReone.MvvmFrame.Wpf;
using GetcuReone.MvvmFrame.Wpf.Entities;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.UiNotification
{
    internal sealed class UiNotificationService : UiServiceBase, IUiNotification
    {
        public void SendNotificationWindow(UiNotificationRequest request)
        {
            VisibleFrame();
            var viewModel = ViewModelBase.CreateViewModel<NotificationWindowViewModel>(Frame, uiServices: UiServices);
            ViewModelBase.Navigate<NotificationWindowPage>(viewModel, request);
        }

        public void VisibleFrame()
        {
            Frame.Visibility = Visibility.Visible;
        }

        public void CollapseFrame()
        {
            Frame.Visibility = Visibility.Collapsed;
        }
    }
}
