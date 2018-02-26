using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using calls.callsbyuserbl;
using calls.Models;

namespace calls.Controllers
{
    public class callsbyuserController : ApiController
    {
        [HttpGet]
        [ActionName("Getcallsbyuser")]
        public List<callsbyuser> Getcallsbyuser(int i)
        {
            calsbyuserbl a = new calsbyuserbl();
            return a.Getcallsbyuser(i);

        }
    }
}
