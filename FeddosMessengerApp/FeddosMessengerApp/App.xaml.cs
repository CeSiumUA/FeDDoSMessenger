﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FeddosMessengerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            IFireBaseComponent fireBaseComponent = DependencyService.Get<IFireBaseComponent>();
            if (fireBaseComponent.CheckGooglePlayServicesAvailability())
            {
                AuthPage authPage = new AuthPage();
                MainPage = authPage;
                authPage.OnAuthSuccessfullEvent += () =>
                {
                    MainPage = new MainPage();
                };
            }
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

        private void LoginButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}