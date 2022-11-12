using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using System.Collections.ObjectModel;

namespace GetcuReone.Cdo.Wpf.UiSettings.Models
{
    /// <summary>
    /// Model for <see cref="SettingContext"/>.
    /// </summary>
    public class ContextModel : BaseGrModel
    {
        internal SettingContext Context { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name => Context.Name;

        /// <summary>
        /// Description.
        /// </summary>
        public string Description => Context.Description;

        /// <summary>
        /// Namespaces.
        /// </summary>
        public ObservableCollection<NamespaceModel> Namespaces { get => _namespaces; set => SetPropertyValue(ref _namespaces, value); }
        private ObservableCollection<NamespaceModel> _namespaces;
    }
}
