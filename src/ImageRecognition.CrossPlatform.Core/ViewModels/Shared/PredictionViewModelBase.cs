using Acr.UserDialogs;
using ImageRecognition.CrossPlatform.Core.Abstract;
using ImageRecognition.CrossPlatform.Core.ViewModels.Shared;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using System;
using System.Linq;
using Xamarin.Forms;

namespace ImageRecognition.CrossPlatform.Core.ViewModels
{
    public abstract class PredictionViewModelBase : MvxNavigationViewModel
    {
        private readonly IUserDialogs _userDialogs;
        private readonly IPredictionService _predictionService;

        public PredictionViewModelBase(IMvxLogProvider provider, 
            IMvxNavigationService navigationService, 
            IUserDialogs userDialogs, 
            IPredictionService predictionService)
            : base(provider, navigationService)
        {
            _predictionService = predictionService;
            _userDialogs = userDialogs;
            Predictions = new MvxObservableCollection<PredictedViewModel>();
        }

        #region Properties
        private MvxObservableCollection<PredictedViewModel> _predictions;
        public MvxObservableCollection<PredictedViewModel> Predictions
        {
            get => _predictions;
            set => SetProperty(ref _predictions, value);
        }

        private ImageSource _image;

        public ImageSource Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }
        #endregion

        #region Commands
        private IMvxCommand _uploadCommand;
        public IMvxCommand UploadCommand => _uploadCommand ?? (_uploadCommand = new MvxCommand(Upload));
        #endregion

        #region Private Methods
        private async void Upload()
        {
            FileData fileData = await CrossFilePicker.Current.PickFile();
            if (fileData == null)
                return; // user canceled file picking
            try
            {
                var dictionary = await _predictionService.Predict(fileData);
                var list = dictionary.Select(x => new PredictedViewModel() { Score = x.Value, Label = x.Key }).ToList();
                Predictions = new MvxObservableCollection<PredictedViewModel>(list);
                Image = ImageSource.FromStream(fileData.GetStream);
            }
            catch (Exception e)
            {
                _userDialogs.Alert("Failed to retraive data from server", "Error");
            }
        }
        #endregion
    }
}
