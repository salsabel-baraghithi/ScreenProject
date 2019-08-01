using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class TemplateField
    {
        public long Id { get; set; }
        public String Name { get; set; }

        public int TopPosition { get; set; }
        public int LeftPosition { get; set; }
        public String FontSize { get; set; }
        public String FontFamily { get; set; }
        public String FontColor { get; set; }

        public long TemplateId { get; set; }
        public Template Template  { get; set; }

        public ICollection<EventField> EventFields { get; set; }

    }
}
