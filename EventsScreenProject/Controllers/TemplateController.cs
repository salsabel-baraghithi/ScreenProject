using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsScreenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : Controller
    {
        
        private readonly ITemplateRepo _iTemplateRepo;
        private readonly IMapper _iMapper;

        public TemplateController(ITemplateRepo iTemplateRepo, IMapper iMapper)
        {

            _iTemplateRepo = iTemplateRepo;
            _iMapper = iMapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<Template> Get()
        {
            List<Template> templates = _iTemplateRepo.GetAll();

            return templates;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
