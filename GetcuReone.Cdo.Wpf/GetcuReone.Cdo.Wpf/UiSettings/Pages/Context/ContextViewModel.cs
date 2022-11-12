using GetcuReone.Cdi.Extensions;
using GetcuReone.Cdi.FactFactory;
using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdo.Settings;
using GetcuReone.Cdo.Settings.Entities;
using GetcuReone.Cdo.Wpf.FactFactory;
using GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings;
using GetcuReone.Cdo.Wpf.FactFactory.SpecialFacts;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.Cdo.Wpf.UiSettings.Models;
using GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace;
using GetcuReone.FactFactory.Entities;
using GetcuReone.MvvmFrame.Wpf.Commands;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetcuReone.Cdo.Wpf.UiSettings.Pages.Context
{
    /// <summary>
    /// View-model.
    /// </summary>
    public sealed class ContextViewModel : BaseGrViewModel
    {
        internal List<Setting> ChangedSettings { get; private set; }

        /// <summary>
        /// Context.
        /// </summary>
        public ContextModel Context { get => _context; set => SetPropertyValue(ref _context, value); }
        private ContextModel _context;

        /// <summary>
        /// Select namespace.
        /// </summary>
        public NamespaceModel SelectNamespace
        {
            get => _selectNamespace;
            set
            {
                if (SetPropertyValue(ref _selectNamespace, value) && value != null)
                    Navigate<NamespacePage, NamespaceViewModel>(value);
            }
        }
        private NamespaceModel _selectNamespace;

        /// <summary>
        /// Command for <see cref="Ok(CommandArgs)"/>
        /// </summary>
        public Command Ok_Command { get => _ok_Command; set => SetPropertyValue(ref _ok_Command, value); }
        private Command _ok_Command;

        /// <inheritdoc/>
        protected override void Initialize()
        {
            base.Initialize();

            Ok_Command = new Command(Ok);
        }

        /// <inheritdoc/>
        protected override async ValueTask OnGoPageAsync(object navigateParam)
        {
            if (navigateParam is List<SettingValueError> settingValueErrors)
            {
                var container = new FactContainer
                {
                    new OpenSettings_ViewModel(this),
                    new OpenSettings_SettingValueErrors(settingValueErrors),
                };

                IGrFactFactory factory = GetFactFactory<CdoWpfRulesProvider>();

                factory.WantFacts((Version1 v, OpenSettings_ContextModel context) =>
                {
                    Context = context;
                }, container);

                await factory.DeriveAsync();

                foreach (var settingModel in Context.Namespaces.SelectMany(n => n.Settings))
                    settingModel.Initialize();
            }
            else if (Context == null)
                TryGoBack();

            await base.OnGoPageAsync(navigateParam);
        }

        private void Ok(CommandArgs args)
        {
            var container = new FactContainer
            {
                new OpenSettings_NamespaceModels(Context.Namespaces.ToList()),
            };

            IGrFactFactory factory = GetFactFactory<CdoWpfRulesProvider>();

            factory.WantFacts((Version1 v, OpenSettings_Settings_Changed changed) =>
            {
                ChangedSettings = changed;
            }, container);

            factory.Derive();

            if (!ChangedSettings.IsNullOrEmpty())
            {
                GetAdapter<SettingsAdapter>()
                    .SetSettings(ChangedSettings.ConvertAll(setting => new SetSettingsRequest
                    {
                        FullCode = setting.FullCode,
                        Value = setting.Value,
                    }));
            }

            TryGoBack();
            Awaiter.Finish();
        }
    }
}
