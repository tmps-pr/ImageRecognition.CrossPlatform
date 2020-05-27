using MvvmCross.ViewModels;

namespace ImageRecognition.CrossPlatform.Core.ViewModels.Shared
{
    public class PredictedViewModel : MvxNotifyPropertyChanged
    {
        private float _score;

        public float Score
        {
            get => _score;
            set => SetProperty(ref _score, value);
        }

        private string _label;

        public string Label
        {
            get => _label;
            set => SetProperty(ref _label, value);
        }
    }
}
