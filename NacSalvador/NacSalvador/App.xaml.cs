using MediaManager;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NacSalvador
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CrossMediaManager.Current.Init();
            CrossMediaManager.Current.Notification.ShowNavigationControls = false;
            MediaManager.CrossMediaManager.Current.Queue.Title = "Nac Savador";
            CrossMediaManager.Current.AutoPlay = true;

            MainPage = new Paginas.PageNac();
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
