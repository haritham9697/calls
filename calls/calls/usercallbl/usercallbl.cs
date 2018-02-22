using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calls.usercalldl;
using calls.Models;

namespace calls.usercallbl
{
    public class usercalbl
    {
        public List<usercalls> Getcalls()
        {
            usercaldl a = new usercaldl();
            return a.Getcalls();
        }
    }
}