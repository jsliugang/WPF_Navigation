using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp_Navigation_.Messages;
using WpfApp_Navigation_.Services;

namespace WpfApp_Navigation_.ViewModels
{
    class SecondViewModel : ViewModelBase
    {
        private string text;
        public string Text { get => text; set => Set(ref text, value); }

        private readonly INavigationService navigation;

        public SecondViewModel(INavigationService navigation)
        {
            this.navigation = navigation;
        }

        private RelayCommand<string> sendCommand;
        public RelayCommand<string> SendCommand
        {
            get => sendCommand ?? (sendCommand = new RelayCommand<string>(
            param =>
            {
                if (param == "First")
                {
                    Messenger.Default.Send(new FirstMessage { Message = Text });
                    navigation.Navigate("First");
                }
                else if (param == "Third")
                {
                    Messenger.Default.Send(new ThirdMessage { Message = Text });
                    navigation.Navigate("Third");
                }
            }
            ));
        }

        private RelayCommand<MouseButtonEventArgs> doubleClickCommnad;
        public RelayCommand<MouseButtonEventArgs> DoubleClickCommnad
        {
            get => doubleClickCommnad ?? (doubleClickCommnad = new RelayCommand<MouseButtonEventArgs>(
            e =>
            {
                MessageBox.Show(e.ClickCount.ToString());
            }
            ));
        }
    }
}
