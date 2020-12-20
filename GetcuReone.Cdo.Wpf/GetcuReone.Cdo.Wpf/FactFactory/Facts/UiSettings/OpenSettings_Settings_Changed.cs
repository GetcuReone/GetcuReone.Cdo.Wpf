using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.FactFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// List of changed settings.
    /// </summary>
    internal sealed class OpenSettings_Settings_Changed : FactBase<List<Setting>>
    {
        public OpenSettings_Settings_Changed(List<Setting> value) : base(value)
        {
        }
    }
}
