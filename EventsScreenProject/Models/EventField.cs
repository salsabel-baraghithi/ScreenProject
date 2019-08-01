using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class EventField
    {
        public long Id { get; set; }
        public String Value { get; set; }

        public long EventId { get; set; }
        public Event Event { get; set; }

        public long TemplateFiledId { get; set; }
        public TemplateField TemplateField { get; set; }



    }
}
