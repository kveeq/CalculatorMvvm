using CalculatorMvvm.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculatorPage();
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
