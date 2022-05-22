using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class User
    {
        public int id { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public string name { set; get; }
        public string address { set; get; }
        public int type { set; get; }
    }
}
