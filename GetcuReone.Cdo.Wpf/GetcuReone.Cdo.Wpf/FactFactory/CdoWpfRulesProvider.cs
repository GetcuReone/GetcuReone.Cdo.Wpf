using GetcuReone.Cdi.Extensions;
using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdm.Errors;
using GetcuReone.Cdo.Settings;
using GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings;
using GetcuReone.Cdo.Wpf.FactFactory.SpecialFacts;
using GetcuReone.Cdo.Wpf.UiSettings;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.Cdo.Wpf.UiSettings.Models;
using GetcuReone.FactFactory.Entities;
using GetcuReone.FactFactory.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GetcuReone.Cdo.Wpf.FactFactory
{
    internal sealed class CdoWpfRulesProvider : BaseGrFactRulesProvider
    {
        /// <inheritdoc/>
        public override IEnumerable<IFact> GetDefaultFacts()
        {
            return new List<IFact>
            {
                new Version1(),
            };
        }

        /// <inheritdoc/>
        public override IFactRuleCollection GetRules()
        {
            var rules = new FactRuleCollection();

            rules.AddRange(UiSettingsRules());

            return rules;
        }

        private FactRuleCollection UiSettingsRules()
        {
            return new FactRuleCollection
            {
                (Version1 v, OpenSettings_SettingModel model) =>
                {
                    return new OpenSettings_SettingValueError(model.Value.ValueError
                        ?? new SettingValueError
                        {
                            ErrorMessage = "Invalid setting value. Make sure you set the value correctly",
                            SettingFullCode = model.Value.Setting.FullCode,
                        });
                },
                (Version1 v, OpenSettings_SettingModel model) =>
                {
                    return new OpenSettings_SettingModel_Setting(model.Value.ToSetting());
                },
                (Version1 v, OpenSettings_SettingModel model) =>
                {
                    return new OpenSettings_SettingModel_SettingType(model.Value.SettingType);
                },
                (Version1 v, OpenSettings_SettingModel_Setting setting,  OpenSettings_SettingValueError settingValueError, OpenSettings_SettingModel_SettingType type) =>
                {
                    var errors = new List<string>();

                    try
                    {
                        GetAdapter<SettingsAdapter>().ValidateSetting(setting, type);
                    }
                    catch(GetcuReoneException)
                    {
                        errors.Add(settingValueError.Value.ErrorMessage);
                    }
                    catch
                    {
                        throw;
                    }

                    return new OpenSettings_SettingModel_ValidationErrors(errors);
                },
                (Version1 v) =>
                {
                    return new OpenSettings_Context(
                        GetAdapter<SettingsAdapter>().GetContext(true));
                },
                (Version1 v) =>
                {
                    return new OpenSettings_SettingTypes(
                        GetAdapter<SettingsAdapter>().GetSettingTypes());
                },
                (Version1 v, OpenSettings_Context context, OpenSettings_SettingTypes settingTypes, OpenSettings_SettingValueErrors settingValueErrors, OpenSettings_ViewModel viewModel) =>
                {
                    return new OpenSettings_NamespaceModels(
                        GetFacade<UiSettingFacade>().GetNamespaceModels(context, settingTypes.Value, settingValueErrors, viewModel.Value));
                },
                (Version1 v, OpenSettings_Context context, OpenSettings_NamespaceModels namespaces, OpenSettings_ViewModel viewModel) =>
                {
                    var result = new ContextModel
                    {
                        Context = context,
                        Namespaces = new ObservableCollection<NamespaceModel>(namespaces),
                    };

                    viewModel.Value.BindModel(result);
                    return new OpenSettings_ContextModel(result);
                },
                (Version1 v, OpenSettings_NamespaceModels namespaces) =>
                {
                    return new OpenSettings_SettingModels(
                        namespaces.Value.SelectMany(item => item.Settings).ToList());
                },
                (Version1 v, OpenSettings_SettingModels settings) =>
                {
                    return new OpenSettings_Settings_Changed(
                        settings.Value
                            .Where(setting => !setting.Value.EqualsOrdinal(setting.Setting.Value))
                            .Select(UiSettingsHelper.ToSetting)
                            .ToList());
                }
            };
        }
    }
}
