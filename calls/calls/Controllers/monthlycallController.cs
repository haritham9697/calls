using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using monthlycalls.Models;
using monthlycalls.monthlycallbl;

namespace monthlycalls.Controllers
{
    public class monthlycallController : ApiController
    {
        [HttpGet]
        [ActionName("Getcallsbymonth")]
        public List<monthlycals> Getcallsbymonth(string id)
        {
            monthlycalbl a = new monthlycalbl();
            return a.Getcallsbymonth(id);
        }
    }
}
