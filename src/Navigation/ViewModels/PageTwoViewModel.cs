using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;

namespace Navigation.ViewModels
{
    public class PageTwoViewModel :ViewModelBase
    {
        public PageTwoViewModel()
        {
            InitCommands();
        }

        public ICommand GoBackCommand { get; private set; }
        public ICommand GoForwardCommand { get; private set; }

        private void InitCommands()
        {
            GoBackCommand = new RelayCommand(() =>
            {
                var navigation = SimpleIoc.Default.GetInstance<INavigationService>();
                navigation.GoBack();
            });
            GoForwardCommand = new RelayCommand(() =>
            {
                var navigation = SimpleIoc.Default.GetInstance<INavigationService>();
                navigation.NavigateTo("Page3");
            });
        }
    }
}
