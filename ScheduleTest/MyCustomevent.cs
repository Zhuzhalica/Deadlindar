﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfSchedule;

namespace ScheduleTest
{
    public class MyCustomEvent : ICalendarEvent
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Label { get; set; }
    }
}