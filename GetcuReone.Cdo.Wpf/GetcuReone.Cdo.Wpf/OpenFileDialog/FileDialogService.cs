﻿using GetcuReone.Cdo.Wpf.OpenFileDialog.Entities;
using GetcuReone.ComboPatterns.Factory;
using System.Linq;

namespace GetcuReone.Cdo.Wpf.OpenFileDialog
{
    /// <inheritdoc cref="IFileDialog"/>
    internal sealed class FileDialogService : FactoryBase, IFileDialog
    {
        /// <inheritdoc />
        public SelectFilesResult SelectFiles(SelectFilesRequest request)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();

            if (!string.IsNullOrEmpty(request.TitleDialog))
                dialog.Title = request.TitleDialog;

            if (!string.IsNullOrEmpty(request.InitialFolder))
                dialog.InitialDirectory = request.InitialFolder;

            dialog.Filter = request.Filter;
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
