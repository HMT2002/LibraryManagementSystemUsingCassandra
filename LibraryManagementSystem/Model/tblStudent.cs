using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class tblStudent
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string Address { set; get; }
        public string Email { set; get; }

        public int Type { set; get; }
        public string Password { set; get; }

    }
}
