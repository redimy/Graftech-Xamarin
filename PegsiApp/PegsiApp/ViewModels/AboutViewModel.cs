using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace PegsiApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://web.mindlink.mx/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}