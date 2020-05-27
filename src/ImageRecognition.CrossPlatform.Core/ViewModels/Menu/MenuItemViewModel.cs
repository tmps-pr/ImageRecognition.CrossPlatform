using ImageRecognition.CrossPlatform.Core.Enums;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageRecognition.CrossPlatform.Core.ViewModels
{
    public class MenuItemViewModel : MvxNotifyPropertyChanged
    {
        private bool _isEnabled;

        private string _title;

        private Type _viewModelType;

        private MenuItemType _menuItemType;

        public MenuItemType MenuItemType
        {
            get => _menuItemType;
            set => SetProperty(ref _menuItemType, value, nameof(MenuItemType));
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value, nameof(Title));
        }

        public Type ViewModelType
        {
            get => _viewModelType;
            set => SetProperty(ref _viewModelType, value, nameof(ViewModelType));
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value, nameof(IsEnabled));
        }
    }
}
