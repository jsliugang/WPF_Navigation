using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Navigation_.Services;
using WpfApp_Navigation_.ViewModels;

namespace WpfApp_Navigation_
{
    class ViewModelLocator
    {
        private AppViewModel appViewModel;
        private FirstViewModel firstViewModel;
        private SecondViewModel secondViewModel;
        private ThirdViewModel thirdViewModel;

        private INavigationService navigationService;

        public ViewModelLocator()
        {
            navigationService = new NavigationService();

            appViewModel = new AppViewModel(navigationService);
            firstViewModel = new FirstViewModel();
            secondViewModel = new SecondViewModel(navigationService);
            thirdViewModel = new ThirdViewModel();

            navigationService.Register("First", firstViewModel);
            navigationService.Register("Second", secondViewModel);
            navigationService.Register("Third", thirdViewModel);

            navigationService.Navigate("First");
        }

        public ViewModelBase GetAppViewModel()
        {
            return appViewModel;
        }
    }
}
