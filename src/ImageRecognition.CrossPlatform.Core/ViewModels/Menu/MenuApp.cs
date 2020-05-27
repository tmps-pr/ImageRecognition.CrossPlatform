using ImageRecognition.CrossPlatform.Core.ViewModels.AgeRecognition;
using ImageRecognition.CrossPlatform.Core.ViewModels.GenderRecognition;
using System.Collections.Generic;

namespace ImageRecognition.CrossPlatform.Core.ViewModels
{
    public class MenuApp
    {
        public MenuApp()
        {
            MenuItems = new List<MenuItemViewModel>();
            InitMenuItems();
        }

        public IList<MenuItemViewModel> MenuItems { get; }

        private void InitMenuItems()
        {
            var genderMenu = new MenuItemViewModel()
            {
                IsEnabled = true,
                Title = "Gender Recognition",
                ViewModelType = typeof(GenderRecognitionPageViewModel),
                MenuItemType = Enums.MenuItemType.GenderRecognition
            };
            MenuItems.Add(genderMenu);

            var ageMenu = new MenuItemViewModel()
            {
                IsEnabled = true,
                Title = "Age Recogntion",
                ViewModelType = typeof(AgeRecognitionPageViewModel),
                MenuItemType = Enums.MenuItemType.AgeRecognition
            };
            MenuItems.Add(ageMenu);
        }
    }
}
