using ImageRecognition.CrossPlatform.Core;
using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.IoC;

namespace ImageRecognition.CrossPlatform.UWP
{
    public class Setup : MvxFormsWindowsSetup<CoreApp, UI.App>
    {
        protected override IMvxIoCProvider InitializeIoC()
        {
            var provider = base.InitializeIoC();
            return SetupIoC.RegisterDependencies(provider);
        }
    }
}
