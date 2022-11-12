using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.FactFactory;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// List of changed settings.
    /// </summary>
    internal sealed class OpenSettings_Settings_Changed : BaseFact<List<Setting>>
    {
        public OpenSettings_Settings_Changed(List<Setting> value) : base(value) { }
    }
}
