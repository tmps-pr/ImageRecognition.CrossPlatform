using ImageRecognition.CrossPlatform.Core.Enums;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace ImageRecognition.CrossPlatform.UI.Convertors
{
    public class MenuItemTypeImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var menuItemType = (MenuItemType)value;

            switch (menuItemType)
            {
                case MenuItemType.AgeRecognition:
                    return Application.Current.Resources["IC_Age_Recognition"];
                case MenuItemType.GenderRecognition:
                    return Application.Current.Resources["IC_Gender_Recognition"];
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
