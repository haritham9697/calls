using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using calls.Models;
using calls.usercallbl;

namespace calls.Controllers
{
    public class usercallController : ApiController
    {
        [HttpGet]
        [ActionName("Getcalls")]
        public List<usercalls> Getcall()
        {
            usercalbl b = new usercalbl();
            return b.Getcalls();
        }
        
    }
}
