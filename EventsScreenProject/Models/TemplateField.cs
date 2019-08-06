using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class TemplateField:IBaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public String Name { get; set; }

        public int? TopPosition { get; set; }
        public int? LeftPosition { get; set; }
        public String FontSize { get; set; }
        public String FontFamily { get; set; }
        public String FontColor { get; set; }
        public String FontWeight { get; set; }
        public String FontStyle { get; set; }

        public long? TemplateId { get; set; }
        public Template MyTemplate { get; set; }

        public ICollection<EventField> EventFields { get; set; }

    }
}
