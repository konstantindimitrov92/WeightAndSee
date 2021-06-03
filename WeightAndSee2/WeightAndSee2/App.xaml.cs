using System;
using WeightAndSee2.Services;
using WeightAndSee2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightAndSee2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
