using ImageRecognition.CrossPlatform.Core.Enums;
using ImageRecognition.CrossPlatform.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ImageRecognition.CrossPlatform.UI.Convertors
{
    public class MenuButtonColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is MenuItemViewModel menu)) return null;

            switch (menu.MenuItemType)
            {
                case MenuItemType.AgeRecognition:
                    return "#1d2846";
                case MenuItemType.GenderRecognition:
                    return "#253a73";
                default:
                    return "#1d2846";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new NotSupportedException();
        }
    }
}
