using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System.Windows;

namespace Navigation.Views
{
    /// <summary>
    /// 主视图交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            this.Loaded += (sender, args) =>
            {
                var navigation = SimpleIoc.Default.GetInstance<INavigationService>();
                navigation.NavigateTo("Page1");
            };
        }
    }
}
