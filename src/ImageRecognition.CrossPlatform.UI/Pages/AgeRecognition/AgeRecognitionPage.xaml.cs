using ImageRecognition.CrossPlatform.Core.ViewModels.AgeRecognition;
using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageRecognition.CrossPlatform.UI.Pages.AgeRecognition
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgeRecognitionPage : MvxContentPage<AgeRecognitionPageViewModel>
    {
        public AgeRecognitionPage()
        {
            InitializeComponent();
        }
    }
}