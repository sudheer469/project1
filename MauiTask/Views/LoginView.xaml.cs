using MauiTask.Bootstrap;
using MauiTask.ViewModels;

namespace MauiTask.Views;

public partial class LoginView : ContentPage
{
    public LoginView()
    {
        InitializeComponent();
        BindingContext = IOCConfiguration.ServiceProvider?.GetService<LoginViewModel>();
    }
}