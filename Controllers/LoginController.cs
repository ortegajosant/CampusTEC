using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace proyectoprogramado.Controllers
{
    [ApiController]
    [Route("campustec/login")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Initial", "Hello" };
        }

        [HttpPost("{id}/{pass}")]
        public IEnumerable<string> Post(int id, string pass)
        {
            if (id == 0){
                return new string[] { id.ToString() , pass };
            }
            else{
                return new string[] {"You are my friend aahhhh"};
            }
            
        }

        [HttpGet("{id}")]
        public string Get(int id){
            return "value";
        }
    }
}