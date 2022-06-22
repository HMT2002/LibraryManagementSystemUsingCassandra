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
    public partial class userBookSearch : Form
    {
        // userid and pwd
        public int userid;
        public string password;
        Func<Row, tblBook> BookSelector;

        private void userBookSearch_Load(object sender, EventArgs e)
        {

            BookSelector = delegate (Row r)
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


            string query = "SELECT * FROM books where status = 0  ALLOW FILTERING";

            var IssueTable = DataConnection.Ins.session.Execute(query)
                .Select(BookSelector);


            userBookSearchDgv.DataSource = IssueTable.ToList();

            userBookSearchDgv.ReadOnly = true;

            userBookSearchRbTitle.Select();
        }

        private void UserBookSearchBtnSearch_Click(object sender, EventArgs e)
        {
            if (userBookSearchRbTitle.Checked == true)
            {
                string query = "SELECT * FROM books Where title = '" + UserBookSearchTbxQuery.Text.Trim() + "' and  status = 0 ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                userBookSearchDgv.DataSource = BookTable.ToList();
            }

            else if(userBookSearchRbAuthor.Checked == true)
            {
                string query = "SELECT * FROM books Where author = '" + UserBookSearchTbxQuery.Text.Trim() + "' and  status = 0 ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                userBookSearchDgv.DataSource = BookTable.ToList();
            }
        }

        private void userBookSeacrhBtnChangePassword_Click(object sender, EventArgs e)
        {
            // hide current form and show next

            this.Hide();
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void UserBookSearchBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        public userBookSearch()
        {
            InitializeComponent();
        }
        private void usrBookSearchBtnIssuedBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            usrIssuedBooks uib = new usrIssuedBooks();
            uib.Show();
        }

        private void userBookSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
