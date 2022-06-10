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
        public int userid;
        public string password;
        int selected_book_id;
        tblBook tb = new tblBook();

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

        }

        private void admBookSearchBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admBookSearchBtnSearch_Click(object sender, EventArgs e)
        {


            if (admBookSearchRbBoth.Checked == true)
            {

            }
            else if (admBookSearchRbTitle.Checked == true)
            {
                string query = "SELECT * FROM books Where title = '" + admBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                admBookSearchDgv.DataSource = BookTable.ToList();

            }
            else if (admBookSearchRbAuthor.Checked == true)
            {
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

        private void admBookSearchDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != admBookSearchDgv.Rows.Count)
            {
                // copy value to variable even if unnecessary
                selected_book_id = Convert.ToInt32(admBookSearchDgv.Rows[e.RowIndex].Cells[0].Value);


                string booksquery = "SELECT picture FROM books where id = " + selected_book_id + " ALLOW FILTERING;";
                var bookresults = DataConnection.Ins.session.Execute(booksquery).FirstOrDefault();
                tb.Data = bookresults.GetValue<byte[]>("picture");
                tb.convertImgFromByte();
                pictureBox1.Image = tb.Img;
            }
        }
    }
}
