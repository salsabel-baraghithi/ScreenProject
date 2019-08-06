using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.ViewModels
{
    public class EventFieldViewModel
    {
        public String Name { get; set; }
        public String Value { get; set; }

        public int TopPosition { get; set; }
        public int LeftPosition { get; set; }
        public String FontSize { get; set; }
        public String FontFamily { get; set; }
        public String FontColor { get; set; }
        public String FontWeight { get; set; }
        public String FontStyle { get; set; }
    }
}
