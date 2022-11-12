using GetcuReone.Cdo.Wpf.UiSettings.Models;
using GetcuReone.FactFactory;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// List <see cref="NamespaceModel"/>.
    /// </summary>
    internal sealed class OpenSettings_NamespaceModels : BaseFact<List<NamespaceModel>>
    {
        public OpenSettings_NamespaceModels(List<NamespaceModel> value) : base(value) { }
    }
}
