using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace ImageRecognition.CrossPlatform.Core.ViewModels
{
    public class MenuPageViewModel : MvxNavigationViewModel
    {
        public MenuPageViewModel(IMvxLogProvider provider, IMvxNavigationService navigationService) : base(provider, navigationService)
        {
        }

        #region Overridess
        public override async Task Initialize()
        {
            MenuItems = new MvxObservableCollection<MenuItemViewModel>(new MenuApp().MenuItems);
            await base.Initialize();
        }

        #endregion Overridess

        #region Properties

        private MvxObservableCollection<MenuItemViewModel> _menuItems = new MvxObservableCollection<MenuItemViewModel>();

        public MvxObservableCollection<MenuItemViewModel> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }
        #endregion

        #region Commands

        private IMvxAsyncCommand<MenuItemViewModel> _navigateToMenuItemCommand;
        public IMvxAsyncCommand<MenuItemViewModel> NavigateToMenuItemCommand =>
            _navigateToMenuItemCommand ??
            (_navigateToMenuItemCommand =
                new MvxAsyncCommand<MenuItemViewModel>(NavigateToMenuItem));

        #endregion Commands

        #region Private Functions

        private Task NavigateToMenuItem(MenuItemViewModel menuItemViewModel)
        {
            if (menuItemViewModel.IsEnabled)
            {
                return NavigationService.Navigate(menuItemViewModel.ViewModelType);
            }

            return Task.CompletedTask;
        }
        #endregion

    }
}
