﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Core;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Core.Reference
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SomePage());
        }

    }
}
