using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdo.Wpf.UiSettings.Models;
using System.Collections.ObjectModel;

namespace GetcuReone.Cdo.Wpf.UiSettings
{
    internal static class UiSettingsHelper
    {
        internal static Setting ToSetting(this SettingModel model)
        {
            return new Setting
            {
                Code = model.Setting.Code,
                DefaultValue = model.Setting.DefaultValue,
                Description = model.Description,
                FullCode = model.Setting.FullCode,
                Name = model.Name,
                Type = model.SettingType.Code,
                Value = model.Value,
            };
        }

        internal static NamespaceModel MapToNamespaceModel(
            this SettingNamespace settingNamespace,
            string namespacesPath,
            BaseGrViewModel viewModel)
        {
            var result = new NamespaceModel
            {
                NamespacePath = namespacesPath,
                Namespace = settingNamespace,
                Settings = new ObservableCollection<SettingModel>(),
            };

            viewModel.BindModel(result);
            return result;
        }
    }
}
