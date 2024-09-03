using MauiTask.Bootstrap;
using MauiTask.ViewModels;

namespace MauiTask.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
        BindingContext = IOCConfiguration.ServiceProvider?.GetService<HomeViewModel>();
    }
}