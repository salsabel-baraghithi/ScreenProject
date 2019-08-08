using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsScreenProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsScreenProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppSettingController : Controller
    {
        private readonly IConfiguration _configuration;
        

        public AppSettingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

       
        // GET: api/<controller>
        [HttpGet("SwappingTime")]
        public String GetSwappingTime()
        {
            String SwappingTime = _configuration.GetSection("AppSettings").GetSection("SwappingTime").Value;
            return SwappingTime;
        }

        // GET: api/<controller>
        [HttpGet("DefaultImg")]
        public String GetDefaultImg()
        {
            String DefaultImg = _configuration.GetSection("AppSettings").GetSection("DefaultImg").Value;
            return DefaultImg;
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
