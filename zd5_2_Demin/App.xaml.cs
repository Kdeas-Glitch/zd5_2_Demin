﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd5_2_Demin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Welcome();
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
