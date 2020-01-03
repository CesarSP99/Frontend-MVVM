using StudentApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        ApiService apiService = new ApiService();
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void btLogin_Clicked(object sender, EventArgs e)
        {
            var connection = await apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                await DisplayAlert(
                     "Internet Error",
                     connection.Message,
                     "Accept"
                    );
                return;
            }
            else
            {
                var response = await apiService.GetToken(Ajustes.APIURL, tbcorreo.Text, tbpass.Text);
                if (response.ErrorDescription.Length != 0)
                {
                    
                }
                else
                {
                    await DisplayAlert(
                     "Error",
                     "Usuario o contraseña incorrecta",
                     "Accept"
                    );
                return;
                }
            }
        }
    }
}