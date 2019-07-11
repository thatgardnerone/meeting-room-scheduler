using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace MeetingRoomScheduler.ViewModels
{
    public class MeetingViewModel
    {
        public ObservableCollection<Meeting> Meetings { get; set; }

        List<string> eventNameCollection;
        List<Color> colorCollection;


        public MeetingViewModel()
        {

        }


    }
}
