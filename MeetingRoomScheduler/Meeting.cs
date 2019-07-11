using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MeetingRoomScheduler
{
    public class Meeting
    {
        public string EventName { get; set; }

        public string Organizer { get; set; }

        public string EventID { get; set; }

        public int Capacity { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public Color Color { get; set; }

        public bool AllDay { get; set; }
    }
}
