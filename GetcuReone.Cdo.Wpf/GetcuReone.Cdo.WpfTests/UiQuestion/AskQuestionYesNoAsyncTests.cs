using GetcuReone.Cdo.Wpf.UiQuestion;
using GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo;
using GetcuReone.Cdo.Wpf.UiQuestion.Entities;
using GetcuReone.GetcuTestAdapter;
using GetcuReone.MvvmFrame.Wpf.TestAdapter;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System.Windows.Controls;

namespace GetcuReone.Cdo.WpfTests.UiQuestion
{
    [TestClass]
    public sealed class AskQuestionYesNoAsyncTests : UiTestBase
    {
        protected override void SetupViewModel<TViewModel>(TViewModel viewModel)
        {
            var subFrame = GetSubFrame();
            viewModel.UiServices.SetupUiQuestion(subFrame);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Show question.")]
        [Timeout(Timeouts.Second.Ten)]
        public void ShowQuestionTestCase()
        {
            string question = "You asked?";
            string questionDetail = "your detail";

            GivenShowEmptyPage()
                .When("Show question", viewModel =>
                {
                    viewModel.UiServices.GetUiService<IUiQuestion>().AskQuestionYesNoAsync(new AskQuestionRequest
                    {
                        Question = question,
                        QuestionDetail = questionDetail,
                    });
                })
                .ThenWait(Timeouts.Millisecond.Hundred)
                .And("Check page.", _ => 
                    CheckTypeAndGetPageSubFrame<AskQuestionYesNoPage>())
                .And("Check view-model.", page => 
                    page.CheckTypeAndDataContext<AskQuestionYesNoViewModel>())
                .AndAreEqual(viewModel => viewModel.Question, question)
                .AndAreEqual(viewModel => viewModel.QuestionDetail.Text, questionDetail)
                .AndAreEqual(viewModel => viewModel.QuestionDetail.Visibility, Visibility.Visible)
                .RunTestWindow(Timeouts.Second.Ten);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Show question without detail.")]
        [Timeout(Timeouts.Second.Ten)]
        public void ShowQuestionWithoutDetailTestCase()
        {
            string question = "You asked?";

            GivenShowEmptyPage()
                .When("Show question", viewModel =>
                {
                    viewModel.UiServices.GetUiService<IUiQuestion>().AskQuestionYesNoAsync(new AskQuestionRequest
                    {
                        Question = question,
                    });
                })
                .ThenWait(Timeouts.Millisecond.Hundred)
                .And("Check page.", _ => 
                    CheckTypeAndGetPageSubFrame<AskQuestionYesNoPage>())
                .And("Check view-model.", page => 
                    page.CheckTypeAndDataContext<AskQuestionYesNoViewModel>())
                .AndAreEqual(viewModel => viewModel.Question, question)
                .AndAreEqual(viewModel => viewModel.QuestionDetail.Visibility, Visibility.Collapsed)
                .RunTestWindow(Timeouts.Second.Ten);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Answer yes to the question.")]
        [Timeout(Timeouts.Second.Ten)]
        public void AnswerYesToQuestionTestCase()
        {
            string question = "You asked?";

            GivenShowEmptyPage()
                .And("Show question", viewModel =>
                {
                    var taskAnswer = viewModel.UiServices.GetUiService<IUiQuestion>().AskQuestionYesNoAsync(new AskQuestionRequest
                    {
                        Question = question,
                    });
                    return taskAnswer;
                })
                .AndWait(Timeouts.Millisecond.Hundred)
                .When("Click btnYes", taskAnswer =>
                {
                    CheckTypeAndGetPageSubFrame<AskQuestionYesNoPage>()
                        .FindChildByName<Button>("btnYes")
                        .OnClick();
                    return taskAnswer;
                })
                .ThenWait(Timeouts.Millisecond.Hundred)
                .AndAsync("Check result", async taskAnswer => await taskAnswer)
                .AndIsNotNull()
                .And("Check result", result =>
                {
                    Assert.IsNotNull(result.Answer, "Answer cannot be null.");
                    Assert.IsTrue(result.Answer.Value, "Expected another answer value.");
                })
                .RunTestWindow(Timeouts.Second.Ten);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Answer no to the question.")]
        [Timeout(Timeouts.Second.Ten)]
        public void AnswerNoToQuestionTestCase()
        {
            string question = "You asked?";

            GivenShowEmptyPage()
                .And("Show question", viewModel =>
                {
                    var taskAnswer = viewModel.UiServices.GetUiService<IUiQuestion>().AskQuestionYesNoAsync(new AskQuestionRequest
                    {
                        Question = question,
                    });
                    return taskAnswer;
                })
                .AndWait(Timeouts.Millisecond.Hundred)
                .When("Click btnNo", taskAnswer =>
                {
                    CheckTypeAndGetPageSubFrame<AskQuestionYesNoPage>()
                        .FindChildByName<Button>("btnNo")
                        .OnClick();
                    return taskAnswer;
                })
                .ThenWait(Timeouts.Millisecond.Hundred)
                .AndAsync("Check result", async taskAnswer => await taskAnswer)
                .AndIsNotNull()
                .And("Check result", result =>
                {
                    Assert.IsNotNull(result.Answer, "Answer cannot be null.");
                    Assert.IsFalse(result.Answer.Value, "Expected another answer value.");
                })
                .RunTestWindow(Timeouts.Second.Ten);
        }
    }
}
