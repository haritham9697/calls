using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calls.Models;
using calls.monthlycalldl;

namespace calls.monthlycallbl
{
    public class monthlycalbl
    {
        public List<monthlycalls> Getcallsbymonth(String month)
        {
            monthlycaldl a = new monthlycaldl();
            return a.Getcallsbymonth(month);
        }
    }
}