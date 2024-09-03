using MauiTask.ViewModels;
using MauiTask.Views;

namespace MauiTask.Bootstrap
{
    public static class IOCConfiguration
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        public static void ConfigureServices()
        {
            ServiceCollection services = new();

            //ViewModels
            services.AddTransient<LoginViewModel>();
            services.AddTransient<HomeViewModel>();
            services.AddTransient<DetailsView>();
            services.AddTransient<ProfileViewModel>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
