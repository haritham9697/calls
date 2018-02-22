using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calls.Models
{
    public class usercalls
    {
        public int userid { get; set; }
        public String username { get; set; }
        public int callid{ get; set; }
        public String month { get; set; }
        public String duration{ get; set; }
        public String calltype { get; set; }
        public String category { get; set; }
        public String specialist { get; set; }
    }
}