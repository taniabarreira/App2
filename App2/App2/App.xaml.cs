﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace App2
{
    public partial class App : Application
    {
        public static Services.IAuthenticationService Authenticator { get; private set; }
        public static void InitializeAuthentication(Services.IAuthenticationService authenticator)
        {
            Authenticator = authenticator;
        }
        public static MainViewModel ViewModel { get; set; }
        public App()
        {
            InitializeComponent();

            //MainPage = new App2.MainPage();
            MainPage = new NavigationPage(new App2.MainPage());
        }

        protected override void OnStart()
        {
            MobileCenter.Start($"android={Common.MobileCenterConstants.AndroidAppId};" +
                          $"ios={Common.MobileCenterConstants.iOSAppId}",
                          typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
