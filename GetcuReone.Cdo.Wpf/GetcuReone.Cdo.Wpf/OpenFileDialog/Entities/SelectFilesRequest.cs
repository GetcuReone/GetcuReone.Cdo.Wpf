namespace GetcuReone.Cdo.Wpf.OpenFileDialog.Entities
{
    /// <summary>
    /// Request for selection files.
    /// </summary>
    public sealed class SelectFilesRequest
    {
        /// <summary>
        /// Title dialog.
        /// </summary>
        public string TitleDialog { get; set; }
        /// <summary>
        /// Filter for files.
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// Can I select multiple files.
        /// </summary>
        public bool MultiSelect { get; set; }
    }
}
