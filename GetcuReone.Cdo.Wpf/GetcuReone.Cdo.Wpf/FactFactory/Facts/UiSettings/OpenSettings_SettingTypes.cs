using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.FactFactory;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// Setting type list.
    /// </summary>
    internal sealed class OpenSettings_SettingTypes : FactBase<IReadOnlyCollection<SettingType>>
    {
        public OpenSettings_SettingTypes(IReadOnlyCollection<SettingType> value) : base(value)
        {
        }
    }
}
