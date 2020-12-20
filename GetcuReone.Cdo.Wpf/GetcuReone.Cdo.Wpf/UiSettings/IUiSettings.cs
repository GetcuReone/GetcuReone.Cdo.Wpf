using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetcuReone.Cdo.Wpf.UiSettings
{
    /// <summary>
    /// Service for UI settings.
    /// </summary>
    public interface IUiSettings
    {
        /// <summary>
        /// Open settings.
        /// </summary>
        /// <param name="settingValueErrors">(optional)</param>
        /// <returns>Changed settings.</returns>
        ValueTask<List<Setting>> OpenSettingsAsync(List<SettingValueError> settingValueErrors = null);
    }
}
