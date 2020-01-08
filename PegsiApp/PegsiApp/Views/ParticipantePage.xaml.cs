using PegsiApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PegsiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParticipantePage : ContentPage
    {
        public ParticipantePage()
        {
            InitializeComponent();
            BindingContext = new ScannerViewModel(this.Navigation);
            Title = "CONTROL DE ACCESO";
        }

    


    }
}
