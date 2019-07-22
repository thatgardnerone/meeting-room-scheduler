using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MeetingRoomScheduler.Pages
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
		{
			await Navigation.PopModalAsync();
		}
    }
}
