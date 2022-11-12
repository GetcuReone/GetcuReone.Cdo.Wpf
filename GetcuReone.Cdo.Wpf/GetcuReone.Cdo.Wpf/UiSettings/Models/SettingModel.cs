using GetcuReone.Cdi;
using GetcuReone.Cdi.Extensions;
using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdo.Wpf.FactFactory;
using GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings;
using GetcuReone.Cdo.Wpf.FactFactory.SpecialFacts;
using GetcuReone.Cdo.Wpf.Models;
using GetcuReone.Cdo.Wpf.UiNotification;
using GetcuReone.Cdo.Wpf.UiNotification.Entities;
using GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.FactFactory.Entities;
using GetcuReone.MvvmFrame.Entities;
using GetcuReone.MvvmFrame.EventArgs;
using GetcuReone.MvvmFrame.Wpf.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.UiSettings.Models
{
    /// <summary>
    /// Setting model.
    /// </summary>
    public class SettingModel : BaseGrModel
    {
        internal Setting Setting { get; set; }

        internal SettingType SettingType { get; set; }

        internal SettingValueError ValueError { get; set; }

        /// <summary>
        /// Permissible values.
        /// </summary>
        public ObservableCollection<RadioButtonModel> PermissibleValues { get => _permissibleValues; set => SetPropertyValue(ref _permissibleValues, value); }
        private ObservableCollection<RadioButtonModel> _permissibleValues;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name => Setting.Name;

        /// <summary>
        /// Description.
        /// </summary>
        public string Description => Setting.Description;

        /// <summary>
        /// Code.
        /// </summary>
        public string Code => Setting.Code;

        /// <summary>
        /// IsEnubled <see cref="PermissibleValues"/>.
        /// </summary>
        public bool PermissibleValuesIsEnabled => SettingType.FormatValue == FormatValue.Enumerate;

        /// <summary>
        /// Visibility <see cref="PermissibleValues"/>
        /// </summary>
        public Visibility PermissibleValuesVisibility => PermissibleValuesIsEnabled ? Visibility.Visible : Visibility.Collapsed;

        /// <summary>
        /// Visibility textbox
        /// </summary>
        public Visibility TextBoxVisibility => SettingType.FormatValue == FormatValue.Text ? Visibility.Visible : Visibility.Collapsed;

        /// <summary>
        /// Value.
        /// </summary>
        public string Value { get => _value; set => SetPropertyValue(ref _value, value); }
        internal string _value;

        private void SetValue(CommandArgs<string> args)
        {
            Value = args.CommandParam;
        }

        /// <inheritdoc/>
        public override void Initialize()
        {
            base.Initialize();

            if (PermissibleValuesIsEnabled)
            {
                if (PermissibleValues == null)
                    PermissibleValues = new ObservableCollection<RadioButtonModel>();
                else
                    PermissibleValues.Clear();

                foreach (var permissibleValue in SettingType.PermissibleValues)
                {
                    var radioModel = new RadioButtonModel
                    {
                        Command = new Command<string>(SetValue),
                        GroupName = Setting.Code,
                        Value = permissibleValue,
                        IsChecked = Value.EqualsOrdinalIgnoreCase(permissibleValue),
                    };
                    BindModel(radioModel);
                    PermissibleValues.Add(radioModel);
                }
            }
        }

        /// <inheritdoc/>
        public override void OnVerification(MvvmElementPropertyVerifyChangeEventArgs e)
        {
            base.OnVerification(e);

            if (!e.IsValid)
                return;

            switch (e.PropertyName)
            {
                case nameof(Value):
                    var container = new FactContainer
                    {
                        new OpenSettings_SettingModel(this)
                    };

                    IGrFactFactory factory = GetFactFactory<CdoWpfRulesProvider>();
                    List<string> errors = null;

                    factory.WantFacts((Version1 v, OpenSettings_SettingModel_ValidationErrors validationErrors) =>
                    {
                        errors = validationErrors;
                    }, container);

                    factory.Derive();

                    if (!errors.IsNullOrEmpty())
                    {
                        foreach (var error in errors)
                            e.AddError(new MvvmFrameErrorDetail
                            {
                                Code = CdoWpfErrorCode.InvalidSettingValue,
                                Message = error,
                            });
                    }
                    break;
            }
        }

        /// <inheritdoc/>
        public override void OnErrors(ReadOnlyCollection<MvvmFrameErrorDetail> details)
        {
            base.OnErrors(details);

            UiServices.GetUiService<IUiNotification>().SendNotificationWindow(new UiNotificationRequest
            {
                Message = string.Join("\n", details.Select(detail => "- " + detail.Message)),
                Title = "Invalid value",
                Type = NotificationTypes.Warning,
            });
        }
    }
}
