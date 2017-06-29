using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic;

namespace WebApi.Controllers
{
    public class GreetingsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Greet()
        {
            return Ok(new Greeting().Greet());
        }
    }
}
