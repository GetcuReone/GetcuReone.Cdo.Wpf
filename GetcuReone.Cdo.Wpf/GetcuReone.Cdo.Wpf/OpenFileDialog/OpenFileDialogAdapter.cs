using GetcuReone.Cdi;
using GetcuReone.Cdo.Wpf.OpenFileDialog.Entities;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog
{
    /// <summary>
    /// Adapter for <see cref="Microsoft.Win32.OpenFileDialog"/>.
    /// </summary>
    public sealed class OpenFileDialogAdapter : GrAdapterProxyBase<IFileDialog>
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(OpenFileDialogAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public OpenFileDialogAdapter()
            : base(() => new FileDialogService())
        {
        }

        /// <summary>
        /// Call Explorer to select files by user.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public SelectFilesResult SelectFiles(SelectFilesRequest request)
        {
            CallMethodLogging(request);

            return ReturnLogging(
                CreateProxy().SelectFiles(request));
        }
    }
}
