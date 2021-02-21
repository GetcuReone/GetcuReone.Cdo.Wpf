using System.Collections.Generic;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog.Entities
{
    /// <summary>
    /// Result for selection files.
    /// </summary>
    public sealed class SelectFilesResult
    {
        /// <summary>
        /// Selected files.
        /// </summary>
        public List<string> SelectedFiles { get; set; }

        /// <summary>
        /// Dilog show result.
        /// </summary>
        public bool? ResultShowDialog { get; set; }
    }
}
