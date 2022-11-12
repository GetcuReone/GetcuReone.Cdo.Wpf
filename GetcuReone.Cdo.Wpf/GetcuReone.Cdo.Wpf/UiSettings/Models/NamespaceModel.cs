using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdm.Configuration.Settings;
using System.Collections.ObjectModel;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.UiSettings.Models
{
    /// <summary>
    /// Model for <see cref="SettingNamespace"/>.
    /// </summary>
    public class NamespaceModel : BaseGrModel
    {
        internal SettingNamespace Namespace { get; set; }

        /// <summary>
        /// Namespace path.
        /// </summary>
        public string NamespacePath { get => _namespacePath; set => SetPropertyValue(ref _namespacePath, value); }
        private string _namespacePath;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name => Namespace.Name;

        /// <summary>
        /// Code.
        /// </summary>
        public string Code => Namespace.Code;

        /// <summary>
        /// Description.
        /// </summary>
        public string Description => Namespace.Description;

        /// <summary>
        /// Settings.
        /// </summary>
        public ObservableCollection<SettingModel> Settings { get => _settings; set => SetPropertyValue(ref _settings, value); }
        private ObservableCollection<SettingModel> _settings;

        /// <summary>
        /// Visibility.
        /// </summary>
        public Visibility Visibility { get => _visibility; set => SetPropertyValue(ref _visibility, value); }
        private Visibility _visibility;
    }
}
