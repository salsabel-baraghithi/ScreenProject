using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class EventField: IBaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public String Value { get; set; }
        public String Type { get; set; }

        public long? EventId { get; set; }
        public Event MyEvent { get; set; }

        public long TemplateFiledId { get; set; }
        public TemplateField MyTemplateField { get; set; }
        
    }
}
