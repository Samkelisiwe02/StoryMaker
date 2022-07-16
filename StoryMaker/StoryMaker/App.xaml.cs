using StoryMaker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryMaker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StoriesPage());
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

