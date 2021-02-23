using GetcuReone.Cdi;
using GetcuReone.Cdo.Process;

namespace GetcuReone.Cdo.Wpf.FileExplorer
{
    /// <summary>
    /// Facade for work with FileExplorer.
    /// </summary>
    public sealed class FileExplorerAdapter : GrAdapterBase
    {
        private readonly string _explorerProgramName = "explorer.exe";

        /// <inheritdoc/>
        protected override string AdapterName => nameof(FileExplorerAdapter);

        /// <summary>
        /// Opens explorer and selects an <paramref name="pathItem"/>.
        /// </summary>
        /// <param name="pathItem"></param>
        public void SelectItem(string pathItem)
        {
            CallMethodLogging(parameter: pathItem);

            GetAdapter<ProcessAdapter>().Start(_explorerProgramName, " /select, " + pathItem);

            ReturnLogging();
        }
    }
}
