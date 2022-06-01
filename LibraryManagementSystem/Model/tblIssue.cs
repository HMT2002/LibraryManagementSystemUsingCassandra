using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class tblIssue
    {
        public int Id { set; get; }
        public int BookId { set; get; }
        public int StudentId { set; get; }
        public string BookName { set; get; }
        public string StudentName { set; get; }
        public DateTime DateIssue { set; get; }

    }
}
