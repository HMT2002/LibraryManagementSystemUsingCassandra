using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class Book
    {
        public int id { set; get; }
        public string title { set; get; }
        public string publisher { set; get; }
        public string genres { set; get; }
        public string author { set; get; }
        public string publishYear { set; get; }
    }
}
