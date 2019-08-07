using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Repository;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;
using Microsoft.EntityFrameworkCore;

namespace EventsScreenProject.Repository
{
    public class TemplateRepo : BaseRepo<Template>, ITemplateRepo
    {
        public readonly MyAppContext _appContext;

        public TemplateRepo(MyAppContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }

        public new List<Template> GetAll()
        {
            return _appContext.Templates
                .Include(t => t.TemplateFields)
                .ToList();

        }
    }
  
}
