using GetcuReone.Cdi;
using GetcuReone.Cdi.Extensions;
using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdo.Wpf.UiNotification;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.Cdo.Wpf.UiSettings.Pages.Context;
using GetcuReone.MvvmFrame.Wpf;
using GetcuReone.MvvmFrame.Wpf.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetcuReone.Cdo.Wpf.UiSettings
{
    internal class UiSettingsService : UiServiceBase, IUiSettings
    {
        public async ValueTask<List<Setting>> OpenSettingsAsync(List<SettingValueError> settingValueErrors = null)
        {
            Validate();

            var viewModel = ViewModelBase.CreateViewModel<ContextViewModel>(Frame, uiServices: UiServices);

            using (Frame.CreateVisibleScope())
            {
                ViewModelBase.Navigate<ContextPage>(viewModel, settingValueErrors.MayBeNull());
                await viewModel.Awaiter.WaitFinishAsync();
            }

            return viewModel.ChangedSettings;
        }

        private void Validate()
        {
            if (!UiServices.Contains<IUiNotification>())
                throw CdiHelper.CreateException(CdoWpfErrorCode.NotificationNotInstalled, "Notification service not installed.");
        }
    }
}
