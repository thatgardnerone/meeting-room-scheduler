using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MeetingRoomScheduler.Pages;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace MeetingRoomScheduler.ViewModels
{
    public class MeetingViewModel
    {
        private List<string> eventNameCollection;
        private List<Color> colorCollection;

        public MeetingViewModel()
        {
            Meetings = new ObservableCollection<Meeting>();

            // Sample data
            CreateEventNameCollection();
            CreateColorCollection();
            CreateAppointments();

            // Interactivity
            ScheduleCellTapped = new Command<CellTappedEventArgs>(CellTapped);
            ScheduleCellDoubleTapped = new Command<CellTappedEventArgs>(DoubleTapped);
            ScheduleCellLongPressed = new Command<CellTappedEventArgs>(LongPressed);
            ScheduleVisibleDatesChanged = new Command<VisibleDatesChangedEventArgs>(VisibleDatesChanged);
        }

        public ObservableCollection<Meeting> Meetings { get; set; }

        public ICommand ScheduleCellTapped { get; set; }

        public ICommand ScheduleCellDoubleTapped { get; set; }

        public ICommand ScheduleCellLongPressed { get; set; }

        public ICommand ScheduleVisibleDatesChanged { get; set; }

        private void CellTapped(CellTappedEventArgs args)
        {
            var selectedDateTime = args.Datetime;
        }

        private void DoubleTapped(CellTappedEventArgs args)
        {
            var selectedDateTime = args.Datetime;
        }

        private void LongPressed(CellTappedEventArgs args)
        {
            var selectedDateTime = args.Datetime;
        }

        private void VisibleDatesChanged(VisibleDatesChangedEventArgs args)
        {
            var visibleDates = args.visibleDates;
        }

        private void CreateEventNameCollection()
        {
            // Fake meeting names
            eventNameCollection = new List<string>
            {
                "General Meeting",
                "Plan Execution",
                "Project Plan",
                "Consulting",
                "Performance Check",
                "Yoga Therapy",
                "Plan Execution",
                "Project Plan",
                "Consulting",
                "Performance Check"
            };

        }

        private void CreateColorCollection()
        {
            // TODO: color scheme?
            colorCollection = new List<Color>
            {
                Color.FromHex("#FF339933"),
                Color.FromHex("#FF00ABA9"),
                Color.FromHex("#FFE671B8"),
                Color.FromHex("#FF1BA1E2"),
                Color.FromHex("#FFD80073"),
                Color.FromHex("#FFA2C139"),
                Color.FromHex("#FFA2C139"),
                Color.FromHex("#FFD80073"),
                Color.FromHex("#FFE671B8"),
                Color.FromHex("#FF00ABA9")
            };
        }

        private void CreateAppointments()
        {
            // Fake appointments
            Random randomTime = new Random();
            List<Point> randomTimeCollection = GettingTimeRanges();
            DateTime date;
            DateTime dateFrom = DateTime.Now.AddDays(-10);
            DateTime dateTo = DateTime.Now.AddDays(10);
            DateTime dataRangeStart = DateTime.Now.AddDays(-3);
            DateTime dataRangeEnd = DateTime.Now.AddDays(3);

            for (date = dateFrom; date < dateTo; date = date.AddDays(1))
            {
                if ((DateTime.Compare(date, dataRangeStart) > 0) && (DateTime.Compare(date, dataRangeEnd) < 0))
                {
                    for (int AdditionalAppointmentIndex = 0; AdditionalAppointmentIndex < 3; AdditionalAppointmentIndex++)
                    {
                        Meeting meeting = new Meeting();
                        int hour = randomTime.Next((int)randomTimeCollection[AdditionalAppointmentIndex].X, (int)randomTimeCollection[AdditionalAppointmentIndex].Y);
                        meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                        meeting.To = meeting.From.AddHours(1);
                        meeting.EventName = eventNameCollection[randomTime.Next(9)];
                        meeting.Color = colorCollection[randomTime.Next(9)];

                        meeting.AllDay |= AdditionalAppointmentIndex % 3 == 0;
                        Meetings.Add(meeting);
                    }
                }
                else
                {
                    Meeting meeting = new Meeting();
                    meeting.From = new DateTime(date.Year, date.Month, date.Day, randomTime.Next(9, 11), 0, 0);
                    meeting.To = meeting.From.AddHours(1);
                    meeting.EventName = eventNameCollection[randomTime.Next(9)];
                    meeting.Color = colorCollection[randomTime.Next(9)];
                    Meetings.Add(meeting);
                }
            }
        }

        private List<Point> GettingTimeRanges()
        {
            List<Point> randomTimeCollection = new List<Point>();
            randomTimeCollection.Add(new Point(9, 11));
            randomTimeCollection.Add(new Point(12, 14));
            randomTimeCollection.Add(new Point(15, 17));
            return randomTimeCollection;
        }
    }
}
