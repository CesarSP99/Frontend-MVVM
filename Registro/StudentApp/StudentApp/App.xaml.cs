using StudentApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
            Ajustes ajustes = new Ajustes();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
