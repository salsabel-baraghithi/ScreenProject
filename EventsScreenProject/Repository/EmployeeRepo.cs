using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Repository;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;

namespace EventsScreenProject.Repository
{
    public class EmployeeRepo : BaseRepo<Employee>, IEmployeeRepo
    {
        public readonly MyAppContext _appContext;

        public EmployeeRepo(MyAppContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }
    }
}
