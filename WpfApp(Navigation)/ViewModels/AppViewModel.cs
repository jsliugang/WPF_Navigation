using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Navigation_.Services;

namespace WpfApp_Navigation_.ViewModels
{
    class AppViewModel : ViewModelBase
    {
        private ViewModelBase currentPage;
        public ViewModelBase CurrentPage { get => currentPage; set => Set(ref currentPage, value); }

        private INavigationService navigationService = new NavigationService();

        private readonly INavigationService navigation;

        public AppViewModel(INavigationService navigation)
        {
            Messenger.Default.Register<ViewModelBase>(this, viewModel => CurrentPage = viewModel);
            this.navigation = navigation;
        }

        private RelayCommand<string> navigateCommand;
        public RelayCommand<string> NavigateCommand
        {
            get => navigateCommand ?? (navigateCommand = new RelayCommand<string>(
            param =>
            {
                navigation.Navigate(param);
            }
            ));
        }
    }
}
