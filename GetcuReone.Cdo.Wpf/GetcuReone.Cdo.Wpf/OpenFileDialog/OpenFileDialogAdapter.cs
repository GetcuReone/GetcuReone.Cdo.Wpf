using GetcuReone.Cdi;
using GetcuReone.Cdo.Wpf.OpenFileDialog.Entities;
using System.Linq;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog
{
    /// <summary>
    /// Adapter for <see cref="Microsoft.Win32.OpenFileDialog"/>.
    /// </summary>
    public sealed class OpenFileDialogAdapter : GrAdapterProxyBase<Microsoft.Win32.OpenFileDialog>
    {
        /// <summary>
        /// Adapter name.
        /// </summary>
        protected override string AdapterName => nameof(OpenFileDialogAdapter);

        /// <summary>
        /// Constructor.
        /// </summary>
        public OpenFileDialogAdapter()
            : base(() => new Microsoft.Win32.OpenFileDialog())
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

            var dialog = CreateProxy();
            dialog.Filter = request.Filter;
            dialog.Title = request.TitleDialog;
            dialog.Multiselect = request.MultiSelect;

            var result = new SelectFilesResult
            {
                ResultShowDialog = dialog.ShowDialog(),
                SelectedFiles = dialog.FileNames.ToList(),
            };

            return ReturnLogging(result);
        }
    }
}
