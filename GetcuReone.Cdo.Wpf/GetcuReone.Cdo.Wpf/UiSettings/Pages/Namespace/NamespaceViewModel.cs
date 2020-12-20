using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdo.Wpf.UiSettings.Models;
using GetcuReone.MvvmFrame.Wpf.Commands;
using System.Threading.Tasks;

namespace GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace
{
    /// <summary>
    /// View-model
    /// </summary>
    public sealed class NamespaceViewModel : GrViewModelBase
    {
        /// <summary>
        /// Context.
        /// </summary>
        public NamespaceModel Namespace { get => _namespase; set => SetPropertyValue(ref _namespase, value); }
        private NamespaceModel _namespase;

        /// <summary>
        /// Command for <see cref="Ok(CommandArgs)"/>
        /// </summary>
        public Command Ok_Command { get => _ok_Command; set => SetPropertyValue(ref _ok_Command, value); }
        private Command _ok_Command;

        /// <inheritdoc/>
        protected override void Initialize()
        {
            base.Initialize();

            Ok_Command = new Command(Ok);
        }

        /// <inheritdoc/>
        protected override ValueTask OnGoPageAsync(object navigateParam)
        {
            if (navigateParam is NamespaceModel namespaceModel)
            {
                Namespace = namespaceModel;
            }
            else if (Namespace == null)
                TryGoBack();

            return base.OnGoPageAsync(navigateParam);
        }

        private void Ok(CommandArgs args)
        {
            TryGoBack();
            Awaiter.Finish();
        }
    }
}
