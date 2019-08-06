using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;
using Microsoft.EntityFrameworkCore;

namespace EventsScreenProject.Repository
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {
        public readonly MyAppContext _appContext;

        public EventRepo(MyAppContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }

        public List<Event> GetTodayEvents()
        {
            DateTime currentDate = DateTime.Now;

            /*
            DateTime currentDate = DateTime.UtcNow;

             List<Event> events = GetOnceEvents(currentDate);
             events = GetDailyEvents(currentDate);
            events = GetMonthlyEvents(currentDate);
            events = GetAnnuallyEvents(currentDate);
             */


            return _appContext.Events.Where(e =>
                    (e.Repeat.Trim().ToLower().Equals("annually") && e.Date.ToString("M").Equals(currentDate.ToString("M"))) ||
                    (e.Repeat.Trim().ToLower().Equals("monthly") && e.Date.ToString("dd").Equals(currentDate.ToString("dd"))) ||
                    (e.Repeat.Trim().ToLower().Equals("daily")) ||
                    (e.Repeat.Trim().ToLower().Equals("once") && e.Date.Date == currentDate.Date)
                )
                .Include(e => e.MyTemplate).ThenInclude(t => t.TemplateFields).ThenInclude(tf => tf.EventFields)
                .Include(e => e.EventFields)
                .ToList();

        }
        private void GetEvents(DateTime date)
        {

        }

        private List<Event> GetAnnuallyEvents(DateTime date)
        {
            return _appContext.Events
                .Where(e =>
                    e.Repeat.Trim().ToLower().Equals("annually") &&
                    e.Date.ToString("M").Equals(date.ToString("M"))
                )
                .Include(e=> e.MyTemplate).ThenInclude(t => t.TemplateFields)
                .Include(e=> e.EventFields)
                .ToList();
        }
        private List<Event> GetMonthlyEvents(DateTime date)
        {
            return _appContext.Events.Where(e =>
                e.Repeat.Trim().ToLower().Equals("monthly") &&
                e.Date.ToString("dd").Equals(date.ToString("dd"))
            ).ToList();
        }
        private List<Event> GetDailyEvents(DateTime date)
        {
            return _appContext.Events.Where(e =>
                e.Repeat.Trim().ToLower().Equals("daily") 
            ).ToList();
        }
        private List<Event> GetOnceEvents(DateTime date)
        {
            return _appContext.Events.Where(e =>
                        e.Repeat.Trim().ToLower().Equals("once") &&
                        e.Date.Date == date.Date
                    ).ToList();
        }
    }

}
