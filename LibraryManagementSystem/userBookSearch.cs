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
        SqlConnection con;
        SqlCommand cmd ;

        // userid and pwd
        public int userid;
        public string password;
        Func<Row, tblBook> BookSelector;

        private void userBookSearch_Load(object sender, EventArgs e)
        {
            //// copy userid and pwd
            //userid = login.userid;
            //password = login.password;

            //// establish connection to db
            //string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            //con = new SqlConnection(connectionString);

            //// on intialise display books table
            //cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books order by book_id asc", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds);

            //userBookSearchDgv.DataSource = ds.Tables[0];



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


            string query = "SELECT * FROM books";

            var BookTable = DataConnection.Ins.session.Execute(query)
                .Select(BookSelector);

            userBookSearchDgv.DataSource = BookTable.ToList();

            //// make dgv read only
            userBookSearchDgv.ReadOnly = true;

            //// select both radio button by default
            userBookSearchRbTitle.Select();
        }

        private void UserBookSearchBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (userBookSearchRbTitle.Checked == true)
            {
                //cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where title like @searchQuery", con);
                //cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //userBookSearchDgv.DataSource = ds.Tables[0];

                string query = "SELECT * FROM books Where title = '" + UserBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                userBookSearchDgv.DataSource = BookTable.ToList();
            }

            //else if(userBookSearchRbBoth.Checked == true)
            //{
            //    //cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where title like @searchQuery or author like @searchQuery", con);
            //    //cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

            //    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    //DataSet ds = new DataSet();
            //    //sda.Fill(ds);

            //    //userBookSearchDgv.DataSource = ds.Tables[0];
            //}

            else if(userBookSearchRbAuthor.Checked == true)
            {
                //cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Y.O.P', genres as 'Genres' from books where author like @searchQuery", con);
                //cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //userBookSearchDgv.DataSource = ds.Tables[0];

                string query = "SELECT * FROM books Where author = '" + UserBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

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
