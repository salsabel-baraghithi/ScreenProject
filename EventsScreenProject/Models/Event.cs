using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class Event: IBaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public String Repeat { get; set; }
        public int Priority { get; set; }

        public long TemplateId { get; set; }
        public Template MyTemplate { get; set; }

        public ICollection<EventField> EventFields { get; set; }


    }
}
