using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using App2.Services;

namespace App2.UWP
{
    public sealed partial class MainPage : IAuthenticationService
    {
        public MainPage()
        {
            this.InitializeComponent();
            App2.App.InitializeAuthentication((IAuthenticationService)this);
            LoadApplication(new App2.App());
        }

        MobileServiceUser user = null;

        public async Task<bool> SignInAsync()
        {
            bool successful = false;

            try
            {
                user = await TelemetryManager.DefaultManager.CurrentClient.LoginAsync(MobileServiceAuthenticationProvider.MicrosoftAccount);
                successful = user != null;
            }
            catch { }

            return successful;
        }

        public async Task<bool> SignOutAsync()
        {
            bool isSuccessful = false;

            try
            {
                await TelemetryManager.DefaultManager.CurrentClient.LogoutAsync();
                isSuccessful = true;
            }
            catch { }

            return isSuccessful;
        }
    }
}
