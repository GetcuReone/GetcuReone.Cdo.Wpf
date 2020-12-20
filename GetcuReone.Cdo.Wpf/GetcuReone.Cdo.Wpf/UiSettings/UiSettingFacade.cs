using GetcuReone.Cdi;
using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.Cdo.Wpf.UiSettings.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.UiSettings
{
    internal sealed class UiSettingFacade : GrFacadeBase
    {
        protected override string FacadeName => nameof(UiSettingFacade);

        private List<NamespaceModel> GetNamespaceModels(SettingNamespace settingNamespace, string namespacesPath, IReadOnlyCollection<SettingType> types, List<SettingValueError> settingValueErrors, GrViewModelBase viewModel)
        {
            var resultSpace = settingNamespace.MapToNamespaceModel(namespacesPath, viewModel);
            var result = new List<NamespaceModel>
            {
                resultSpace,
            };

            if (!settingNamespace.Namespaces.IsNullOrEmpty())
            {
                foreach (var nSpase in settingNamespace.Namespaces)
                    result.AddRange(GetNamespaceModels(nSpase, namespacesPath + settingNamespace.Name + " > ", types, settingValueErrors, viewModel));
            }

            if (!settingNamespace.Settings.IsNullOrEmpty())
            {
                resultSpace.Visibility = Visibility.Visible;

                foreach (var setting in settingNamespace.Settings)
                {
                    var type = types.First(t => t.Code.EqualsOrdinalIgnoreCase(setting.Type));
                    var model = new SettingModel
                    {
                        Setting = setting,
                        _value = setting.Value,
                        SettingType = type,
                        ValueError = settingValueErrors?.FirstOrDefault(pattern => pattern.SettingFullCode.EqualsOrdinalIgnoreCase(setting.FullCode)),
                    };
                    viewModel.BindModel(model);
                    resultSpace.Settings.Add(model);
                }
            }
            else
                resultSpace.Visibility = Visibility.Collapsed;

            return result;
        }

        internal List<NamespaceModel> GetNamespaceModels(SettingContext context, IReadOnlyCollection<SettingType> types, List<SettingValueError> settingValueErrors, GrViewModelBase viewModel)
        {
            return context
                .Namespaces
                .SelectMany(
                    n => GetNamespaceModels(n, context.Name + " > ", types, settingValueErrors, viewModel))
                .ToList();
        }
    }
}
