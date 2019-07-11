using System;
using Syncfusion.Licensing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetingRoomScheduler
{
    public partial class App : Application
    {

        public App()
        {
            SyncfusionLicenseProvider.RegisterLicense("MTE4NjEyQDMxMzcyZTMxMmUzMGNGVFFYZ2o2UHBBY1IxTjRDM2hrZm5CVnUxc1FVL2F0c002cFJBN1poT2M9");
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
