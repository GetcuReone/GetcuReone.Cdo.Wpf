using GetcuReone.MvvmFrame.Interfaces;
using System.Windows.Controls;

namespace GetcuReone.Cdo.Wpf.UiSettings.Pages.Context
{
    /// <summary>
    /// Interaction logic for NotificationWindowPage.xaml
    /// </summary>
    public partial class ContextPage : Page, IPage
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

        private void listNamespaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listNamespaces.UnselectAll();
        }
    }
}
