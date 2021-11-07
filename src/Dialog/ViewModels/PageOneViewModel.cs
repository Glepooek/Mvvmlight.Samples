using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Dialog.Services;
using System.Windows.Input;

namespace Dialog.ViewModels
{
    public class PageOneViewModel : ViewModelBase
    {
        #region Constructor

        public PageOneViewModel(IFrameNavigationService navigationService)
        {
            mNavigationService = navigationService;
            InitCommands();
        }

        #endregion

        #region Fields

        private INavigationService mNavigationService;

        #endregion

        #region Commands

        public ICommand GoForwardCommand { get; private set; }

        private void InitCommands()
        {
            GoForwardCommand = new RelayCommand(() =>
            {
                mNavigationService.NavigateTo(PageKeyConstant.PageTwo, new string[] { "I", "love", "you" });
            });
        }

        #endregion
    }
}
