using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTask.Models
{
    public partial class Details : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private string subTitle;
    }
}
