using GetcuReone.MvvmFrame.Interfaces;
using System.Windows.Controls;

namespace GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo
{
    /// <summary>
    /// Interaction logic for AskQuestionYesNoPage.xaml
    /// </summary>
    public partial class AskQuestionYesNoPage : Page, IPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="viewModel"></param>
        public void InitializePageComponent<TViewModel>(TViewModel viewModel) where TViewModel : IViewModel
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
