using GetcuReone.MvvmFrame.Wpf.Interfaces;
using System.Windows.Controls;

namespace GetcuReone.Cdo.Wpf.UiSettings
{
    /// <summary>
    /// Setup helper.
    /// </summary>
    public static class UiSettingsSetupHelper
    {
        /// <summary>
        /// Install <see cref="IUiSettings"/>.
        /// </summary>
        /// <param name="configUi"></param>
        /// <param name="frame">Frame for bind.</param>
        public static void SetupUiSettings<TConfigUiServices>(this TConfigUiServices configUi, Frame frame)
            where TConfigUiServices : IConfigUiServices
        {
            configUi.AddSingleton<IUiSettings, UiSettingsService>(frame);
        }
    }
}
