﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using usermonth.usermonthbl;
using usermonth.Models;

namespace usermonth.Controllers
{
    public class usermonthController : ApiController
    {
        [HttpGet]
        [ActionName("Getcallsbyusermonth")]
        public List<usermonthly> Getcallsbyusermonth(int userid,string month)
        {
            usrmonthbl a = new usrmonthbl();
            return a.Getcallsbyusermonth(userid,month);
        }
    }
}
