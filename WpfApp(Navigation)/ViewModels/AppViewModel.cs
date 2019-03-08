using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Navigation_.ViewModels
{
    class AppViewModel : ViewModelBase
    {
        private ViewModelBase currentPage;
        public ViewModelBase CurrentPage { get => currentPage; set => Set(ref currentPage, value); }

        public AppViewModel()
        {
            viewModels.Add("First", new FirstViewModel());
            viewModels.Add("Second", new SecondViewModel());

            CurrentPage = viewModels["First"];
        }

        private Dictionary<string, ViewModelBase> viewModels = new Dictionary<string, ViewModelBase>();

        private RelayCommand<string> navigateCommand;
        public RelayCommand<string> NavigateCommand
        {
            get => navigateCommand ?? (navigateCommand = new RelayCommand<string>(
            param =>
            {
                CurrentPage = viewModels[param];
            }
            ));
        }
    }
}
