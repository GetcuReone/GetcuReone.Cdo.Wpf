using GetcuReone.Cdo.Wpf.UiSettings.Models;
using GetcuReone.FactFactory;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// List <see cref="SettingModel"/>.
    /// </summary>
    internal sealed class OpenSettings_SettingModels : BaseFact<List<SettingModel>>
    {
        public OpenSettings_SettingModels(List<SettingModel> value) : base(value) { }
    }
}
