﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReserver.Server.Client.Models
{
    class MenuItem : BindableObject
    {
        string title;
        MenuItemType menuItemType;
        Type viewModelType;
        bool isEnabled;

        public string Title
        {
            get => title;

            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public MenuItemType MenuItemType
        {
            get => menuItemType;

            set
            {
                menuItemType = value;
                OnPropertyChanged();
            }
        }

        public Type ViewModelType
        {
            get => viewModelType;

            set
            {
                viewModelType = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabled
        {
            get => isEnabled;

            set
            {
                isEnabled = value;
                OnPropertyChanged();
            }
        }

        public Func<Task> AfterNavigationAction { get; set; }
    }
}
