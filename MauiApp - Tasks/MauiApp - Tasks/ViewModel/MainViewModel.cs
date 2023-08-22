using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp___Tasks.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity) 
        {
            Tasks = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> tasks;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Oops!", "You don't have access to the internet!", "I understand!");
                return;
            }

            Tasks.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Remove(string task)
        {
            if (Tasks.Contains(task)) 
            { 
                Tasks.Remove(task);
            }
        }

        [RelayCommand]
        async Task Tap(string task)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={task}");
        }
    }
}
