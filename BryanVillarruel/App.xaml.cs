﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BryanVillarruel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            //MainPage = new NavigationPage(new Resumen());
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
