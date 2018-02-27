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
        public List<usermonthly> Getcallsbyusermonth(int userid,string month)
        { 
            usrmonthdl a = new usrmonthdl();
            return a.Getcallsbyusermonth( userid, month);
        }
    }
}