using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PegsiApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
            firstPassword.ReturnCommand = new Command(() => secondPassword.Focus());
        }
        private async void userIdCheckEvent(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(useridValidationEntry.Text)) || (string.IsNullOrWhiteSpace(useridValidationEntry.Text)))
            {
                await DisplayAlert("Alerta", "Ingresa usuario.", "OK");
            }
           
        }
        private async void Password_ClickedEvent(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(firstPassword.Text)) || (string.IsNullOrWhiteSpace(secondPassword.Text)))
            {
                await DisplayAlert("Alert", "Ingresa la contraseña", "OK");
            }
            
        }
        private async void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {
            if (userNameEntry.Text != null && passwordEntry.Text != null)
            {
                var validData = LoginValidate(userNameEntry.Text, passwordEntry.Text);
                if (validData == 2)
                {
                    App.IsUserLoggedIn = true;
                    popupLoadingView.IsVisible = false;
                    await App.NavigatiPageAsync(loginPage, userNameEntry.Text, validData);
                }
                
                else
                {
                    popupLoadingView.IsVisible = false;
                    await DisplayAlert("Login Failed", "Usuario o contraseña incorrectos", "OK");
                }
            }
            else
            {
                popupLoadingView.IsVisible = false;
                await DisplayAlert("Ups!", "Ingresa usuario y contraseña.", "OK");
            }
        }
        public int LoginValidate(string userName1, string pwd1)
        {
            //var data = _SQLiteConnection.Table<User>();
            //var d1 = data.Where(x => x.matricula == userName1 && x.password == pwd1 && x.tipoUsuario != 1).FirstOrDefault();
            //var d2 = data.Where(x => x.matricula == userName1 && x.password == pwd1 && x.tipoUsuario == 1).FirstOrDefault();
            int usuario = 0;
            string user = "gruma01";
            string password = "admin";

            if (userName1 == user && pwd1 == password)
            {
                usuario = 2;
                return usuario;
            }
            //else if (d2 != null)
            //{
            //    usuario = 1;
            //    return usuario;
            //}
            else return usuario;
        }
    }
}