using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new debute();
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
