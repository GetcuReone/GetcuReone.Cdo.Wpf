using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.FactFactory;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// List <see cref="SettingValueError"/>
    /// </summary>
    internal sealed class OpenSettings_SettingValueErrors : BaseFact<List<SettingValueError>>
    {
        public OpenSettings_SettingValueErrors(List<SettingValueError> value) : base(value) { }
    }
}
