using Acr.UserDialogs;
using ImageRecognition.CrossPlatform.Core.Services;
using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace ImageRecognition.CrossPlatform.Core.ViewModels.AgeRecognition
{
    public class AgeRecognitionPageViewModel : PredictionViewModelBase
    {
        public AgeRecognitionPageViewModel(IMvxLogProvider provider, 
            IMvxNavigationService navigationService, 
            IUserDialogs userDialogs,
            AgePredictionService agePredictionService)
            : base(provider, navigationService, userDialogs, agePredictionService)
        {
        }
    }
}
