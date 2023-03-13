﻿using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
namespace TabbedPageIssue.ViewModels
{
    [INotifyPropertyChanged]
    public partial class DummyPageViewModel
    {
        public DummyPageViewModel()
        {
            MonkeyCollection = new ObservableCollection<Monkey>();
            for (int i = 0; i < 100; i++)
            {
                MonkeyCollection.Add(new Monkey { Name = "Dummy" + i, Location = "location" + "98" + i });
            }


        }
        [ObservableProperty]
        private ObservableCollection<Monkey> _monkeyCollection;
    }
}

