using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTask.Models;
using MauiTask.Views;
using System.Collections.ObjectModel;

namespace MauiTask.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private string welcomeText;

        [ObservableProperty]
        private ObservableCollection<Details> details;

        public HomeViewModel()
        {
            Details = new ObservableCollection<Details>
            {
                new Details(){ Title="Title1", SubTitle= "SubTitle1"},
                new Details(){ Title="Title2", SubTitle= "SubTitle2"},
                new Details(){ Title="Title3", SubTitle= "SubTitle3"}
            };
            WelcomeText = "Welcome " + Preferences.Get("NickName", string.Empty);
        }

        [RelayCommand]
        public async Task NavigateToDetailPageAsync(Details details)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DetailsView());
        }
    }
}
