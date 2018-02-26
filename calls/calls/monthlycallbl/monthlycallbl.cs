using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using monthlycalls.Models;
using monthlycalls.monthlycallsdl;

namespace monthlycalls.monthlycallbl
{
    public class monthlycalbl
    {
        public List<monthlycals> Getcallsbymonth(string id)
        {
            monthlycalsdl a = new monthlycalsdl();
            return a.Getcallsbymonth(id);
        }
    }
}