using GetcuReone.Cdo.Wpf.OpenFileDialog.Entities;
using GetcuReone.ComboPatterns.Adapter;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog
{
    /// <summary>
    /// Adapter for <see cref="Microsoft.Win32.OpenFileDialog"/>.
    /// </summary>
    public sealed class OpenFileDialogAdapter : AdapterProxyBase<IFileDialog>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public OpenFileDialogAdapter() : base(() => new FileDialogService()) { }

        /// <inheritdoc cref="IFileDialog.SelectFiles(SelectFilesRequest)"/>
        public SelectFilesResult SelectFiles(SelectFilesRequest request)
        {
            return CreateProxy().SelectFiles(request);
        }
    }
}
