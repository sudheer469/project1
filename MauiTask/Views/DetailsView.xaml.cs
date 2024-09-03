using MauiTask.Bootstrap;
using MauiTask.ViewModels;

namespace MauiTask.Views;

public partial class DetailsView : ContentPage
{
	public DetailsView()
	{
		InitializeComponent();
        BindingContext = IOCConfiguration.ServiceProvider?.GetService<DetailsViewModel>();
    }
}