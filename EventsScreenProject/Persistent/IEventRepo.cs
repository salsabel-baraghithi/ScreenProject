using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Models;

namespace EventsScreenProject.Persistent
{
    public interface IEventRepo : IBaseRepo<Event>
    {
        List<Event> GetTodayEvents();
    }
}
