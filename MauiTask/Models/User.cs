using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTask.Models
{
    public partial class User : ObservableObject
    {
        [ObservableProperty]
        private string nickName;

        [ObservableProperty]
        private string userName;

        [ObservableProperty]
        private string password;
    }
}
