using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using calls.Models;
using calls.callsbyuserdl;
namespace calls.callsbyuserbl
{
    public class calsbyuserbl
    {
        public List<callsbyuser> Getcallsbyuser(int i)
        {
            calsbyuserdl a = new calsbyuserdl();
            return a.Getcallsbyuser(i);

    }
    }
}