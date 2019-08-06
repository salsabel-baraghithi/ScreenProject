using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class Template: IBaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public String Name { get; set; }
        public String BackgroundImg { get; set; }

        public ICollection<TemplateField> TemplateFields { get; set; }
        public ICollection<Event> Events { get; set; }


    }
}
