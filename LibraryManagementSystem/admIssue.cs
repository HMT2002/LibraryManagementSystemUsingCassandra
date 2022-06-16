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
using LibraryManagementSystem.Model;
using Cassandra;

namespace LibraryManagementSystem
{
    public partial class admIssue : Form
    {

        Func<Row, tblIssue> IssueSelector;
        Func<Row, tblBook> BookSelector;
        Func<Row, tblStudent> StudentSelector;


        public admIssue()
        {
            InitializeComponent();
        }

        private void admIssue_Load(object sender, EventArgs e)
        {
            display();
            admIssueRbTitle.Select();
        }

        public void display()
        {
            IssueSelector = delegate (Row r)
            {
                tblIssue card = new tblIssue
                {
                    Id = r.GetValue<int>("id"),
                    BookId = r.GetValue<int>("book"),
                    StudentId = r.GetValue<int>("user"),
                    BookName=r.GetValue<string>("bookname"),
                    StudentName=r.GetValue<string>("username"),
                    DateIssue = r.GetValue<DateTime>("dateissue"),

                };
                return card;
            };

            BookSelector = delegate (Row r)
            {
                tblBook card = new tblBook
                {
                    Id = r.GetValue<int>("id"),
                    Title = r.GetValue<string>("title"),
                    Genres = r.GetValue<string>("genres"),
                    PublishYear = r.GetValue<string>("publishyear"),
                    Publisher = r.GetValue<string>("publisher"),
                    Author = r.GetValue<string>("author"),
                    Status = r.GetValue<int>("status"),
                    UserId = r.GetValue<int>("userid"),
                    UserEmail = r.GetValue<string>("useremail"),
                    DateIssue = r.GetValue<DateTime>("dateissue"),
                };
                return card;
            };


            StudentSelector = delegate (Row r)
            {
                tblStudent card = new tblStudent
                {
                    Id = r.GetValue<int>("id"),
                    Name = r.GetValue<string>("name"),
                    Email = r.GetValue<string>("email"),
                    Type = r.GetValue<int>("type"),
                    Password = r.GetValue<string>("password"),
                    Address = r.GetValue<string>("address"),
                };
                return card;
            };

            string query = "SELECT * FROM books where status = 0  ALLOW FILTERING";
            var IssueTable = DataConnection.Ins.session.Execute(query)
                .Select(BookSelector);

            admIssueDgvTable.DataSource = IssueTable.ToList();

            admIssueDgvTable.ReadOnly = true;
        }

        public void clearFields()
        {
            admIssueTbxSearchQuery.Text = string.Empty;
            admIssueTbxUserID.Text = string.Empty;
            amdIssueTbxBookID.Text = string.Empty;
        }

        private void admIssueDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.RowIndex != admIssueDgvTable.Rows.Count)
            {
                amdIssueTbxBookID.Text = Convert.ToString(admIssueDgvTable.Rows[e.RowIndex].Cells[0].Value);

            }
        }

        private void admIssueBtnIssue_Click(object sender, EventArgs e)
        {
            int user_id = 0; 
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            try
            {
                user_id = int.Parse(admIssueTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an integer.");
                preliminaryAcceptedState = false;
                return;
            }
            try
            {
                book_id = int.Parse(amdIssueTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an interger.");
                preliminaryAcceptedState = false;
                return;

            }
            string query = "SELECT * FROM issues Where user = " + admIssueTbxUserID.Text.Trim() + "  ALLOW FILTERING";

            var IssueTable = DataConnection.Ins.session.Execute(query)
                .Select(IssueSelector);

            int rows = IssueTable.ToList().Count;

            if(rows >= 2)
            {
                MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
                preliminaryAcceptedState = false;
            }


            string query1 = "SELECT * FROM issues Where book = " + amdIssueTbxBookID.Text.Trim() + "  ALLOW FILTERING";

            var IssueTable1 = DataConnection.Ins.session.Execute(query1)
                .Select(IssueSelector);

            int rows1 = IssueTable1.ToList().Count;

            if(rows1 > 0)
            {
                MessageBox.Show("The book has already been issued by someone else.\nCannot issue book.");
                preliminaryAcceptedState = false;
            }

            if(preliminaryAcceptedState == true)
            {
                try
                {

                    string booksquery = "SELECT * FROM books where id = "+ Convert.ToInt32(amdIssueTbxBookID.Text.Trim()) + " and status = 0 ALLOW FILTERING;";
                    string bookname = "";
                    var bookresults = DataConnection.Ins.session.Execute(booksquery).FirstOrDefault();
                    bookname = bookresults.GetValue<string>("title");




                    string usersquery = "SELECT * FROM users where id = " + Convert.ToInt32(admIssueTbxUserID.Text.Trim()) + " ALLOW FILTERING;";
                    string username = "";
                    var userresults = DataConnection.Ins.session.Execute(usersquery).FirstOrDefault();
                    username = userresults.GetValue<string>("name");


                    DateTime tk = DateTime.Now;

                    int issueyear = tk.Year;
                    int issuemonth = tk.Month;
                    int issday = tk.Day;

                    var ps = DataConnection.Ins.session.Prepare("insert into  issues (id ,book,user,bookname,username,dateissue) values (?,?,?,?,?,?);");
                    var querycmd = ps.Bind(randomId(), Convert.ToInt32(amdIssueTbxBookID.Text.Trim()), Convert.ToInt32(admIssueTbxUserID.Text.Trim()), bookname, username, new DateTime(issueyear, issuemonth, issday));
                    DataConnection.Ins.session.Execute(querycmd);


                    var updatebooks = DataConnection.Ins.session.Prepare("update books set status=?, userid = ?, dateissue = ? where id=?;");
                    var updatebooksquery = updatebooks.Bind(1, Convert.ToInt32(admIssueTbxUserID.Text.Trim()), new DateTime(issueyear, issuemonth, issday), Convert.ToInt32(amdIssueTbxBookID.Text.Trim()));
                    DataConnection.Ins.session.Execute(updatebooksquery);
                    MessageBox.Show("Book successfully issued.");

                    display();
                    clearFields();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please make sure that the the Book ID and User ID is valid.\nIf you still get an error then contact the developer. "+ex.Message);
                }

            }
        }

        public int randomId()
        {
            Random rnd = new Random();
            int num = rnd.Next(0,999);


            return num;
        }

        private void admIssueBtnSearch_Click(object sender, EventArgs e)
        {

            if (admIssueTbxSearchQuery.Text.CompareTo(string.Empty) == 0)
            {
                return;
            }

            if (admIssueRbTitle.Checked == true)
            {

                string query = "SELECT * FROM books Where title = '" + admIssueTbxSearchQuery.Text.Trim() + "' and status = 0  ALLOW FILTERING ";

                var IssueTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                admIssueDgvTable.DataSource = IssueTable.ToList();


            }
            else if (admIssueRbAuthor.Checked == true)
            {
                string queryauthor = "SELECT * FROM books Where author = '" + admIssueTbxSearchQuery.Text.Trim() + "' and status = 0  ALLOW FILTERING";
                var authorresults = DataConnection.Ins.session.Execute(queryauthor).Select(BookSelector);

                admIssueDgvTable.DataSource = authorresults.ToList();

            }
        }

        private void admIssueBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admIssueBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
