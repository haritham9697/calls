using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using calls.Models;
using calls.monthlycallbl;

namespace calls.Controllers
{
    public class monthlycallController : ApiController
    {
        [HttpGet]
        [ActionName("Getcallsbymonth")]
        public List<monthlycalls> Getcallsbymonth(int month)
        {
            monthlycalbl a = new monthlycalbl();
            return a.Getcallsbymonth(month);
        }
    }
}
