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
    public partial class admReturn : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        Func<Row, tblIssue> IssueSelector;
        Func<Row, tblBook> BookSelector;

        int issue_id = 0;

        public admReturn()
        {
            InitializeComponent();
        }

        private void admReturn_Load(object sender, EventArgs e)
        {
            // display table
            display();
        }

        // clear text boxes
        private void clear()
        {
            admReturnTbxSearchQuery.Text = string.Empty;
            admReturnTbxUserID.Text = string.Empty;
            amdReturnTbxBookID.Text = string.Empty;

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
                    BookName = r.GetValue<string>("bookname"),
                    StudentName = r.GetValue<string>("username"),
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

            string query = "SELECT * FROM issues ALLOW FILTERING";
            var IssueTable = DataConnection.Ins.session.Execute(query)
                .Select(IssueSelector);

            admReturnDgvTable.DataSource = IssueTable.ToList();

            admReturnDgvTable.ReadOnly = true;
        }
        private void admReturnDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.RowIndex != admReturnDgvTable.Rows.Count )
            {
                issue_id = Convert.ToInt32(admReturnDgvTable.Rows[e.RowIndex].Cells[0].Value);
                int book_id = Convert.ToInt32(admReturnDgvTable.Rows[e.RowIndex].Cells[1].Value);
                int user_id = Convert.ToInt32(admReturnDgvTable.Rows[e.RowIndex].Cells[2].Value);
                amdReturnTbxBookID.Text = Convert.ToString(book_id);
                admReturnTbxUserID.Text = Convert.ToString(user_id);
            }
        }

        private void admReturnBtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(admReturnTbxSearchQuery.Text == string.Empty)
                {
                    display();
                }
                else
                {
                    string query = "SELECT * FROM issues Where book = " + admReturnTbxSearchQuery.Text.Trim() + "  ALLOW FILTERING ";

                    var IssueTable = DataConnection.Ins.session.Execute(query)
                        .Select(IssueSelector);

                    admReturnDgvTable.DataSource = IssueTable.ToList();


                }
            }
            catch
            {
                MessageBox.Show("Please make sure that you enter only an integer in the search box.");
            }
                
        }

        private void admReturnBtnReturn_Click(object sender, EventArgs e)
        {
            int book_id = 0;
            int user_id = 0;
            bool preliminaryAcceptedState = true;
            try
            {
                book_id = int.Parse(amdReturnTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an integer.");
                preliminaryAcceptedState = false;
            }
            try
            {
                user_id = int.Parse(admReturnTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an interger.");
                preliminaryAcceptedState = false;
            }

            // delete record from the db
            if(preliminaryAcceptedState == true)
            {
                try
                {
                    tblIssue tk = new tblIssue();
                    tk.Id = issue_id;

                    var ps = DataConnection.Ins.session.Prepare("DELETE from issues WHERE id = ? ;");
                    var query = ps.Bind(tk.Id);
                    DataConnection.Ins.session.Execute(query);
                    DateTime time = DateTime.Now;

                    int issueyear = 1;
                    int issuemonth = 1;
                    int issday = 1;

                    var updatebooks = DataConnection.Ins.session.Prepare("update books set status=?, userid = ?, dateissue = ? where id=?;");
                    var updatebooksquery = updatebooks.Bind(0, 0, new DateTime(issueyear, issuemonth, issday), book_id);
                    DataConnection.Ins.session.Execute(updatebooksquery);


                    MessageBox.Show("Book successfully returned.");
                    clear();
                    display();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Internal system error.\nPlease contact the developer."+ex.Message);
                }
            }
        }

        private void admReturnBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admReturnBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
