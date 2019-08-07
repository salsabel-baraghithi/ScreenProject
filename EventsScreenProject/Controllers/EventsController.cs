using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;
using EventsScreenProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsScreenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepo _iEventRepo;
        private readonly IMapper _iMapper;

        public EventsController(IEventRepo iEventRepo, IMapper iMapper)
        {
            _iEventRepo = iEventRepo;
            _iMapper = iMapper;
        }

        // GET api/values
        [HttpGet("GetTodayEvents")]
        public List<EventViewModel> GetTodayEvents()
        {
            
            List<Event> events = _iEventRepo.GetTodayEvents();
            /*   return events;*/

            List<EventViewModel> eventViewModels = _iMapper.Map<List<EventViewModel>>(events);
            return eventViewModels;

           
        }
        // GET api/values
        [HttpGet]
        public List<EventViewModel> Get()
        {


            List<Event> events = _iEventRepo.GetAll();
            /*   return events;*/

            List<EventViewModel> eventViewModels = _iMapper.Map<List<EventViewModel>>(events);
            return eventViewModels;

        }
    }
}
