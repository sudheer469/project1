using MauiTask.Bootstrap;
using MauiTask.ViewModels;

namespace MauiTask.Views;

public partial class ProfileView : ContentPage
{
    public ProfileView()
    {
        InitializeComponent();
        BindingContext = IOCConfiguration.ServiceProvider?.GetService<ProfileViewModel>();
    }
}