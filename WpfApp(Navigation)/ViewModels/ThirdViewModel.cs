using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Navigation_.Messages;

namespace WpfApp_Navigation_.ViewModels
{
    class ThirdViewModel : ViewModelBase
    {
        private string message;
        public string Message { get => message; set => Set(ref message, value); }

        public ThirdViewModel()
        {
            Messenger.Default.Register<ThirdMessage>(this,
            msg =>
            {
                Message = msg.Message;
            });
        }
    }
}
