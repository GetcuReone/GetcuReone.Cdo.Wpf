using GetcuReone.FactFactory;
using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings
{
    /// <summary>
    /// Setting model validation errors.
    /// </summary>
    internal sealed class OpenSettings_SettingModel_ValidationErrors : BaseFact<List<string>>
    {
        public OpenSettings_SettingModel_ValidationErrors(List<string> value) : base(value) { }
    }
}
