using GetcuReone.Cdi.MvvmFrameWpf;
using GetcuReone.Cdo.Wpf.Models;
using GetcuReone.Cdo.Wpf.UiQuestion.Entities;
using GetcuReone.MvvmFrame.Wpf.EventArgs;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace GetcuReone.Cdo.Wpf.UiQuestion.UiBase
{
    /// <summary>
    /// Base view-model.
    /// </summary>
    public abstract class BaseAskQuestionViewModel : BaseGrViewModel
    {
        /// <summary>
        /// Page visibility.
        /// </summary>
        public Visibility VisibilityPage { get => _visibilityPage; set => SetPropertyValue(ref _visibilityPage, value); }
        private Visibility _visibilityPage;

        /// <summary>
        /// Text question.
        /// </summary>
        public string Question { get => _question; set => SetPropertyValue(ref _question, value); }
        private string _question;

        /// <summary>
        /// Question detail.
        /// </summary>
        public TextModel QuestionDetail { get; private set; }

        /// <summary>
        /// Answer.
        /// </summary>
        public bool? Answer { get; protected set; }

        /// <summary>
        /// Close question.
        /// </summary>
        protected void CloseQuestion()
        {
            VisibilityPage = Visibility.Collapsed;

            if (NavigationManager.CanGoBack)
                NavigationManager.GoBack();
            QuestionDetail.PropertyChanged -= QuestionDetail_OnPropertyChanged;
        }

        /// <inheritdoc/>
        protected override void Initialize()
        {
            QuestionDetail = GetModel<TextModel>();
            QuestionDetail.Visibility = Visibility.Collapsed;
            QuestionDetail.PropertyChanged += QuestionDetail_OnPropertyChanged;
        }

        /// <inheritdoc/>
        protected override ValueTask OnGoPageAsync(object navigateParam)
        {
            if (navigateParam != null && navigateParam is AskQuestionRequest request)
            {
                VisibilityPage = Visibility.Visible;
                Question = request.Question;
                QuestionDetail.Text = request.QuestionDetail;
            }
            else
                CloseQuestion();

            return default;
        }

        /// <inheritdoc/>
        protected override ValueTask OnLoadPageAsync()
        {
            return default;
        }

        /// <inheritdoc/>
        protected override ValueTask OnLeavePageAsync(NavigatingEventArgs args)
        {
            VisibilityPage = Visibility.Collapsed;
            return default;
        }

        private void QuestionDetail_OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            switch (args.PropertyName)
            {
                case nameof(TextModel.Text):
                    if (!string.IsNullOrEmpty(QuestionDetail.Text))
                    {
                        if (QuestionDetail.Visibility != Visibility.Visible)
                            QuestionDetail.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (QuestionDetail.Visibility != Visibility.Collapsed)
                            QuestionDetail.Visibility = Visibility.Collapsed;
                    }
                    break;
            }
        }
    }
}
