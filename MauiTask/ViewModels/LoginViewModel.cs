using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTask.Models;
using MauiTask.Views;

namespace MauiTask.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private User user;

        public LoginViewModel()
        {
            User = new User();
        }

        [RelayCommand]
        public async Task LoginAsync()
        {
            Preferences.Set("NickName", User.NickName);
            await Application.Current.MainPage.Navigation.PushAsync(new HomeView());
        }
    }
}
