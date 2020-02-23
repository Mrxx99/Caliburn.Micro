using System;
using Caliburn.Micro.Xamarin.Forms;
using Features.Forms2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Features.Forms2
{
    public partial class App : FormsApplication
    {
        public App()
        {
            InitializeComponent();
            DisplayRootViewFor<HomeViewModel>();
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
