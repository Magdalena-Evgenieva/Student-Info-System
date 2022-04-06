using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
   public class User
    {

        public String name{ get; set; }
        public String password { get; set; }
        public String FNumber { get; set; }
        public Int32 role { get; set; }

        public DateTime Created { get; set; }

        public DateTime ValidTo { get; set; }
    }
}
