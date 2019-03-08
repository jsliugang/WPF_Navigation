using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Navigation_.ViewModels
{
    class FirstViewModel : ViewModelBase
    {
        private string message;
        public string Message { get => message; set => Set(ref message, value); }

        public FirstViewModel()
        {
            Messenger.Default.Register<string>(this,
            msg =>
            {
                Message = msg;
            });
        }
    }
}
