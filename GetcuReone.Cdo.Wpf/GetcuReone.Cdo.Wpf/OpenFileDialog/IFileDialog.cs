using GetcuReone.Cdo.Wpf.OpenFileDialog.Entities;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog
{
    /// <summary>
    /// Service for work FileExplorer
    /// </summary>
    public interface IFileDialog
    {
        /// <summary>
        /// Open file explorer to select files.
        /// </summary>
        /// <param name="request">Request.</param>
        /// <returns></returns>
        SelectFilesResult SelectFiles(SelectFilesRequest request);
    }
}
