using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo;
using GetcuReone.Cdo.Wpf.UiQuestion.Entities;
using GetcuReone.MvvmFrame.Wpf;
using GetcuReone.MvvmFrame.Wpf.Entities;
using System.Threading.Tasks;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.UiQuestion
{
    internal sealed class UiQuestionService : UiServiceBase, IUiQuestion
    {
        public async ValueTask<AskQuestionResult> AskQuestionYesNoAsync(AskQuestionRequest request)
        {
            using (Frame.CreateVisibleScope())
            {
                var viewModel = ViewModelBase.CreateViewModel<AskQuestionYesNoViewModel>(Frame);
                var nResult = ViewModelBase.Navigate<AskQuestionYesNoPage>(viewModel, request);

                if (nResult.IsNavigate)
                {
                    while (viewModel.VisibilityPage != Visibility.Collapsed)
                        await Task.Delay(100);
                }

                return new AskQuestionResult
                {
                    Answer = viewModel.Answer,
                };
            }
        }
    }
}
