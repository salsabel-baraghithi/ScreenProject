using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Models;

namespace EventsScreenProject.ViewModels
{
    public class EventViewModel
    {
      
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Priority { get; set; }

        public String Background { get; set; }
        public String TemplateName { get; set; }


        public ICollection<EventFieldViewModel> EventFieldViewModels { get; set; }

        
    }
}
