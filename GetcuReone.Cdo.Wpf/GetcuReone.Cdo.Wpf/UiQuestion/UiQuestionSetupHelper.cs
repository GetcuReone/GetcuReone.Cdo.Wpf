using GetcuReone.MvvmFrame.Wpf.Interfaces;
using System.Windows.Controls;

namespace GetcuReone.Cdo.Wpf.UiQuestion
{
    /// <summary>
    /// Installation Notification Instance Assistant.
    /// </summary>
    public static class UiQuestionSetupHelper
    {
        /// <summary>
        /// Install question service.
        /// </summary>
        /// <param name="configUi"></param>
        /// <param name="frame">Frame for bind.</param>
        public static void SetupUiQuestion<TConfigUiServices>(this TConfigUiServices configUi, Frame frame)
            where TConfigUiServices : IConfigUiServices
        {
            configUi.AddSingleton<IUiQuestion, UiQuestionService>(frame);
        }
    }
}
