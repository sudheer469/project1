using MauiTask.Views;
using MauiTask.Bootstrap;

namespace MauiTask
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            IOCConfiguration.ConfigureServices();
            MainPage = new NavigationPage(new LoginView());
        }
    }
}
