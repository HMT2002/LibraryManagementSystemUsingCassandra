using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Cassandra;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem
{
    public partial class usrIssuedBooks : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        Func<Row, tblBook> IssueSelector;


        public usrIssuedBooks()
        {
            InitializeComponent();
        }

        private void usrIssuedBooks_Load(object sender, EventArgs e)
        {
            // copy userid and pwd
            userid = login.userid;
            password = login.password;

            IssueSelector = delegate (Row r)
            {
                tblBook card = new tblBook
                {
                    Id = r.GetValue<int>("id"),
                    Title = r.GetValue<string>("title"),
                    Publisher = r.GetValue<string>("publisher"),
                    Genres = r.GetValue<string>("genres"),
                    Author = r.GetValue<string>("author"),
                    PublishYear = r.GetValue<string>("publishyear"),
                    Status = r.GetValue<int>("status"),
                    UserId = r.GetValue<int>("userid"),
                    UserEmail = r.GetValue<string>("useremail"),
                    DateIssue = r.GetValue<DateTime>("dateissue"),
                };
                return card;
            };


            string query = "SELECT * FROM books where status = 1 ALLOW FILTERING";

            var IssueTable = DataConnection.Ins.session.Execute(query)
                .Select(IssueSelector);

            usrIssuedBooksDgvBooks.DataSource = IssueTable.ToList();
        }

        private void usrIssuedBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            userBookSearch ubs = new userBookSearch();
            ubs.Show();
        }

        private void usrIssuedBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
