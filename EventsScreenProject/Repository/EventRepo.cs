using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;

namespace EventsScreenProject.Repository
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {
        public readonly MyAppContext _appContext;

        public EventRepo(MyAppContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }
    }

}
