using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingRoomScheduler.ViewModels;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace MeetingRoomScheduler
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Add data from MeetingViewModel
            MeetingViewModel viewModel = new MeetingViewModel();
            schedule.DataSource = viewModel.Meetings;

            // TODO: block out dates that have been booked off
            // https://help.syncfusion.com/xamarin/sfschedule/monthview?cs-save-lang=1&cs-lang=xaml#restricted-days-in-month

            schedule.ShowAppointmentsInline = true;
        }
    }
}
