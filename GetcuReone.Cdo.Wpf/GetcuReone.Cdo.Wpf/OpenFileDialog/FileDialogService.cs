using GetcuReone.Cdi;
using GetcuReone.Cdo.Wpf.OpenFileDialog.Entities;
using System.Linq;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog
{
    internal sealed class FileDialogService : GrFactoryBase, IFileDialog
    {
        protected override string FactoryName => nameof(FileDialogService);

        public SelectFilesResult SelectFiles(SelectFilesRequest request)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            dialog.Filter = request.Filter;
            if (string.IsNullOrEmpty(request.TitleDialog))
                dialog.Title = request.TitleDialog;
            if (string.IsNullOrEmpty(request.InitialFolder))
                dialog.InitialDirectory = request.InitialFolder;
            dialog.CheckFileExists = request.CheckFileExists;
            dialog.Multiselect = request.MultiSelect;

            return new SelectFilesResult
            {
                ResultShowDialog = dialog.ShowDialog(),
                SelectedFiles = dialog.FileNames.ToList(),
            };
        }
    }
}
