using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using usermonth.Models;
using usermonth.usermonthdl;

namespace usermonth.usermonthbl
{
    public class usrmonthbl
    {
        public List<usermonthlly> Getcallsbyusermonth(int i, int idd)
        {
            usrmonthdl a = new usrmonthdl();
            return a.Getcallsbyusermonth(i, idd);
        }
    }
}