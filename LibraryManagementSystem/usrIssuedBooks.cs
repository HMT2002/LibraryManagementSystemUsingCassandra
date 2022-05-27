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

        Func<Row, tblBook> BookSelector;


        public usrIssuedBooks()
        {
            InitializeComponent();
        }

        private void usrIssuedBooks_Load(object sender, EventArgs e)
        {
            // copy userid and pwd
            userid = login.userid;
            password = login.password;

            // establish connection to db
            //string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            //con = new SqlConnection(connectionString);

            //// on intialise display books table
            //cmd = new SqlCommand("select date_issued as 'Date Issued', DATEDIFF(day, date_issued, CONVERT(date, GETDATE()))  as 'Total days passed', book_id as 'Book ID', title as 'Title', author as 'Author', publisher as 'Publisher', year_of_pub as 'Year of Publication', genres as 'Genres' from issue, books where i_user_id = @user_id and i_book_id = book_id", con);
            //cmd.Parameters.AddWithValue("@user_id", userid);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds);

            //usrIssuedBooksDgvBooks.DataSource = ds.Tables[0];
            //usrIssuedBooksDgvBooks.ReadOnly = true;

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

            usrIssuedBooksDgvBooks.DataSource = BookTable.ToList();
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
