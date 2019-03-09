using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Navigation_.Services
{
    interface INavigationService
    {
        void Navigate(string viewName);
        void Register(string viewName, ViewModelBase viewModel);
    }
}
