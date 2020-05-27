using ImageRecognition.CrossPlatform.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace ImageRecognition.CrossPlatform.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MvxContentPage<MenuPageViewModel>
    {
        public MenuPage()
        {
            InitializeComponent();
        }
    }
}