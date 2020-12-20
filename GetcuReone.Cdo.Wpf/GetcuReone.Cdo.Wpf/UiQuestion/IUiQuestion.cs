using GetcuReone.Cdo.Wpf.UiQuestion.Entities;
using System.Threading.Tasks;

namespace GetcuReone.Cdo.Wpf.UiQuestion
{
    /// <summary>
    /// User polling interface through UI.
    /// </summary>
    public interface IUiQuestion
    {
        /// <summary>
        /// Ask a question (yes/no).
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ValueTask<AskQuestionResult> AskQuestionYesNoAsync(AskQuestionRequest request);
    }
}
