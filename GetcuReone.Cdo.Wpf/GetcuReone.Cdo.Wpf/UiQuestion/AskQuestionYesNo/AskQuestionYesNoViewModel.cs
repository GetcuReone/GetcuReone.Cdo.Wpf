using GetcuReone.Cdo.Wpf.UiQuestion.UiBase;
using GetcuReone.MvvmFrame.Wpf.Commands;
using GetcuReone.MvvmFrame.Wpf.Models;

namespace GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo
{
    /// <summary>
    /// View-model.
    /// </summary>
    public sealed class AskQuestionYesNoViewModel : BaseAskQuestionViewModel
    {
        /// <summary>
        /// Button yes.
        /// </summary>
        public ButtonModel<Command> Yes_ButtonModel { get; private set; }

        /// <summary>
        /// Button no.
        /// </summary>
        public ButtonModel<Command> No_ButtonModel { get; private set; }

        /// <inheritdoc/>
        protected override void Initialize()
        {
            base.Initialize();

            Yes_ButtonModel = GetModel<ButtonModel<Command>>();
            Yes_ButtonModel.Command = new Command(e =>
            {
                Answer = true;
                CloseQuestion();
            });

            No_ButtonModel = GetModel<ButtonModel<Command>>();
            No_ButtonModel.Command = new Command(e =>
            {
                Answer = false;
                CloseQuestion();
            });
        }
    }
}
