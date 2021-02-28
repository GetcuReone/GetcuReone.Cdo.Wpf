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

        /// <summary>
        /// The path to the folder that Explorer will open by default.
        /// </summary>
        public string InitialFolder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.
        /// </summary>
        public bool CheckFileExists { get; set; }
    }
}
