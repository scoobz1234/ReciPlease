﻿using ReciPlease.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ReciPlease
{
    public partial class App : Application
    {
        static RecipeDatabaseController recipeDatabase;
        public static string FilePath;

       public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            FilePath = filePath;
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

        public static RecipeDatabaseController RecipeDatabase 
        {
            get 
            {
                if (recipeDatabase == null)
                {
                    recipeDatabase = new RecipeDatabaseController();
                }
                return recipeDatabase;
            }
        }
    }
}
