using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsScreenProject.Models
{
    public class Employee: IBaseModel
    {
        public long Id { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public DateTime Dob { get; set; }
        public String JobTitle { get; set; }
        public String Status { get; set; }
        public String Email { get; set; }
    }
}
