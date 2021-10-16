using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;

namespace Navigation.ViewModels
{
    public class PageOneViewModel: ViewModelBase
    {
        public PageOneViewModel()
        {
            InitCommands();
        }

        public ICommand GoBackCommand { get; private set; }
        public ICommand GoForwardCommand { get; private set; }

        private void InitCommands()
        {
            GoBackCommand = new RelayCommand(()=>
            { 
            
            });
            GoForwardCommand = new RelayCommand(() =>
            {
                var navigation = SimpleIoc.Default.GetInstance<INavigationService>();
                navigation.NavigateTo("Page2");
            });
        }
    }
}
