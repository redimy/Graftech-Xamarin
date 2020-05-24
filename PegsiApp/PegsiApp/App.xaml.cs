using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PegsiApp.Services;
using PegsiApp.Views;
using System.Threading.Tasks;

namespace PegsiApp
{
    public partial class App : Application
    {
        //TODO: Replace with *.azurewebsites.net url after deploying backend to Azure
        //To debug on Android emulators run the web backend against .NET Core not IIS
        //If using other emulators besides stock Google images you may need to adjust the IP address
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;

        public static string MindlinkUrl = "xm.knildnim.amurg";
        public static bool IsUserLoggedIn { get; set; }


        public App()
        {
            InitializeComponent();



            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

        
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        internal static async Task NavigatiPageAsync(Page name, string user, int validData)
        {
            if (validData == 2)
            {
                //Application.Current.MainPage = new NavigationPage(new ParticipantePage());

                //await name.Navigation.PushAsync(new ParticipantePage());

                Application.Current.MainPage = new MainPage();

                await name.Navigation.PushAsync(new MainPage());
            }


        }
    }
}
