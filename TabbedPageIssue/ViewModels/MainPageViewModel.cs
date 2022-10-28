using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
namespace TabbedPageIssue.ViewModels
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModel
    {
        public MainPageViewModel()
        {
            MonkeyCollection = new ObservableCollection<Monkey>();
            for (int i = 0; i < 100; i++)
            {
                MonkeyCollection.Add(new Monkey { Name = "Monkey" + i, Location = "location" + "8" + i });
            }


        }
        [ObservableProperty]
        private ObservableCollection<Monkey> _monkeyCollection;
    }
}

