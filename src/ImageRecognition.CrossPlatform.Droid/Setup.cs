using ImageRecognition.CrossPlatform.Core;
using ImageRecognition.CrossPlatform.UI;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.IoC;
using MvvmCross.Logging;
using Serilog;

namespace ImageRecognition.CrossPlatdorm.Droid.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, App>
    {
        public override MvxLogProviderType GetDefaultLogProviderType()
        {
            return MvxLogProviderType.Serilog;
        }

        protected override IMvxLogProvider CreateLogProvider()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();
            return base.CreateLogProvider();
        }

        protected override IMvxIoCProvider InitializeIoC()
        {
            var provider = base.InitializeIoC();
            return SetupIoC.RegisterDependencies(provider);
        }
    }
}