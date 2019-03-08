using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_Navigation_.ViewModels;
using WpfApp_Navigation_.Views;

namespace WpfApp_Navigation_
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = new AppView();
            window.DataContext = new AppViewModel();
            window.ShowDialog();
        }
    }
}
