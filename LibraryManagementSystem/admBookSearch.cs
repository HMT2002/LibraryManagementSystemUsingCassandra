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
using Cassandra.Mapping;

namespace LibraryManagementSystem
{
    public partial class admBookSearch : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        Func<Row, tblBook> BookSelector;


        private readonly IMapper mapper = new Mapper(DataConnection.Ins.session);

        public admBookSearch()
        {
            InitializeComponent();

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

            admBookSearchDgv.DataSource = BookTable.ToList();

            admBookSearchRbTitle.Select();
        }



        private void admBookSearch_Load(object sender, EventArgs e)
        {
            //// copy userid and pwd
            //userid = login.userid;
            //password = login.password;

            //// establish connection to db
            //string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            //con = new SqlConnection(connectionString);

            //// on intialise display books table
            //cmd = new SqlCommand("select book_id as 'Book ID', title as 'Title', author as 'Author', i_user_id as 'User ID', name as 'User Name', date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', publisher as 'Publisher', year_of_pub as 'Year of Pub', genres as 'Genres' from books left join issue on i_book_id = book_id left join users on i_user_id = user_id", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds);

            //admBookSearchDgv.DataSource = ds.Tables[0];

            //// make read only
            //admBookSearchDgv.ReadOnly = true;

            //// select both radio button by default
            //admBookSearchRbBoth.Select();


            //User user = mapper.Fetch<User>(query).ToList().FirstOrDefault();
            //if (user != null)
            //{
            //    userid = user.id;
            //    password = user.password;
            //    this.Hide();
            //    if (user.type == 1)
            //    {
            //        admStartPage menuF = new admStartPage();
            //        menuF.Show();
            //    }
            //    else
            //    {
            //        userBookSearch ubs = new userBookSearch();
            //        ubs.Show();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Wrong email or password!!!!");
            //}

        }

        private void admBookSearchBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admBookSearchBtnSearch_Click(object sender, EventArgs e)
        {
            //if (con.State == ConnectionState.Closed)
            //    con.Open();

            if (admBookSearchRbBoth.Checked == true)
            {
                //cmd = new SqlCommand("select * from books where title like @searchQuery or author like @searchQuery", con);
                //cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //editBookDBDgvTable.DataSource = ds.Tables[0];

            }
            else if (admBookSearchRbTitle.Checked == true)
            {
                //cmd = new SqlCommand("select * from books where title like @searchQuery", con);
                //cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //editBookDBDgvTable.DataSource = ds.Tables[0];

                string query = "SELECT * FROM books Where title = '" + admBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                admBookSearchDgv.DataSource = BookTable.ToList();

            }
            else if (admBookSearchRbAuthor.Checked == true)
            {
                //cmd = new SqlCommand("select * from books where author like @searchQuery", con);
                //cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //editBookDBDgvTable.DataSource = ds.Tables[0];


                string query = "SELECT * FROM books Where author = '" + admBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                admBookSearchDgv.DataSource = BookTable.ToList();

            }
        }

        private void admBookSearchBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admBookSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
