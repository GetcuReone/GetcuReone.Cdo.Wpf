namespace GetcuReone.Cdo.Wpf.UiQuestion.Entities
{
    /// <summary>
    /// Request to ask a question.
    /// </summary>
    public class AskQuestionRequest
    {
        /// <summary>
        /// Text question.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Additional information to the question.
        /// </summary>
        public string QuestionDetail { get; set; }
    }
}
