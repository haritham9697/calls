using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calls.Models;
using calls.usermonthdl;

namespace calls.usermonthbl
{
    public class usrmonthbl
    {
        public List<usermonth> Getcallsbyusermonth(int id, int month)
        {
            usrmonthdl a = new usrmonthdl();
            return a.Getcallsbyusermonth(id, month);
        }
    }
}