using GetcuReone.Cdo.Process;
using GetcuReone.ComboPatterns.Adapter;

namespace GetcuReone.Cdo.Wpf.FileExplorer
{
    /// <summary>
    /// Facade for work with FileExplorer.
    /// </summary>
    public sealed class FileExplorerAdapter : AdapterBase
    {
        private const string _explorerProgramName = "explorer.exe";

        /// <summary>
        /// Opens explorer and selects an <paramref name="pathItem"/>.
        /// </summary>
        /// <param name="pathItem"></param>
        public void SelectItem(string pathItem)
        {
            GetAdapter<ProcessAdapter>().Start(_explorerProgramName, " /select, " + pathItem);
        }
    }
}
