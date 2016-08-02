using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorbisHotDog.ViewModels;
using Xamarin.Forms;

namespace NorbisHotDog.Pages
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel vm;
        public LoginPage()
        {
            InitializeComponent();
            vm = new LoginViewModel();
            this.BindingContext = vm;
            
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Login", vm.CheckUserDetails() ? "Success login" : "Failed login", "OK");
            if (Device.OS == TargetPlatform.Android)
                DependencyService.Get<IContinueAndroid>().StartIntent();
        }
    }
}

