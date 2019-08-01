using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class Event: IBaseModel
    {
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Repeat { get; set; }
        public int Priority { get; set; }

        public long TemplateId { get; set; }
        public Template MyTemplate { get; set; }

        public ICollection<EventField> EventFields { get; set; }


    }
}
