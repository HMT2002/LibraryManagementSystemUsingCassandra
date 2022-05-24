using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class tblBook
    {
        public int Id { set; get; }
        public string Title { set; get; }

        public string Publisher { set; get; }
        public string Genres { set; get; }

        public string Author { set; get; }
        public string PublishYear { set; get; }
        public int Status { set; get; }

        public int UserId { set; get; }
        public string UserEmail { set; get; }

        public DateTime DateIssue { set; get; }
    }
}
