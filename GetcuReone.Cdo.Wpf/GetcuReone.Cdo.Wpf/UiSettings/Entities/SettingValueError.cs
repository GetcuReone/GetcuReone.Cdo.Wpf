namespace GetcuReone.Cdo.Wpf.UiSettings.Entities
{
    /// <summary>
    /// Setting validation error text
    /// </summary>
    public sealed class SettingValueError
    {
        /// <summary>
        /// <see cref="Cdm.Configuration.Settings.Setting.FullCode"/>.
        /// </summary>
        public string SettingFullCode { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
