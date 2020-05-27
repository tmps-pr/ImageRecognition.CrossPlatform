using ImageRecognition.CrossPlatform.Core.ViewModels.GenderRecognition;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace ImageRecognition.CrossPlatform.UI.Pages.GenderRecognition
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenderRecognitionPage : MvxContentPage<GenderRecognitionPageViewModel>
    {
        public GenderRecognitionPage()
        {
            InitializeComponent();
        }
    }
}