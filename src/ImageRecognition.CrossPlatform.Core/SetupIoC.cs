using Acr.UserDialogs;
using ImageRecognition.CrossPlatform.Core.Services;
using MvvmCross.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageRecognition.CrossPlatform.Core
{
    public static class SetupIoC
    {
        public static IMvxIoCProvider RegisterDependencies(IMvxIoCProvider provider)
        {
            provider.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);
            provider.ConstructAndRegisterSingleton(typeof(GenderPredictionService));
            provider.ConstructAndRegisterSingleton(typeof(AgePredictionService));
            return provider;
        }
    }
}
