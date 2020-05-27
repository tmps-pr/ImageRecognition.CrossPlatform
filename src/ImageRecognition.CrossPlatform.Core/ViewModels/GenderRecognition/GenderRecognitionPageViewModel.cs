using Acr.UserDialogs;
using ImageRecognition.CrossPlatform.Core.Services;
using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace ImageRecognition.CrossPlatform.Core.ViewModels.GenderRecognition
{
    public class GenderRecognitionPageViewModel : PredictionViewModelBase
    {
        public GenderRecognitionPageViewModel(IMvxLogProvider provider,
            IMvxNavigationService navigationService, 
            IUserDialogs userDialogs, 
            GenderPredictionService genderPredictionService) 
            : base(provider, navigationService, userDialogs, genderPredictionService)
        {
        }
    }
}
