using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using calls.usermonthbl;
using calls.Models;

namespace calls.Controllers
{
    public class usermonthController : ApiController
    {
        [HttpGet]
        [ActionName("Getcallsbyusermonth")]
        public List<usermonth> Getcallsbyusermonth(int id, int month)
        {
            usrmonthbl a = new usrmonthbl();
            return a.Getcallsbyusermonth(id, month);
        }
    }
}
