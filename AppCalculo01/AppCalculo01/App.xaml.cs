﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalculo01.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCalculo01
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeRegularModule())
                                  .With(new Plugin.Iconize.Fonts.FontAwesomeBrandsModule())
                                  .With(new Plugin.Iconize.Fonts.FontAwesomeSolidModule());

            MainPage = new MainPage();
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
    }
}
