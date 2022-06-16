using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Cassandra;
using LibraryManagementSystem.Model;
using Cassandra.Serialization;

namespace LibraryManagementSystem
{
    public partial class admEditBookDB : Form
    {
        // selected book id
        int selected_book_id;
        tblBook tb = new tblBook();
        private void admEditBookDB_Load(object sender, EventArgs e)
        {

            // display table
            displayBooks();

            // select both radio button by default
            admEditBookDBRbTitle.Select();
        }


        Func<Row, tblBook> BookSelector;

        // display the table of books
        public void displayBooks()
        {
            try
            {
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
                string query = "SELECT * FROM books";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                editBookDBDgvTable.DataSource = BookTable.ToList();
                // make read only
                editBookDBDgvTable.ReadOnly = true;
            }
            catch
            {

            }

        }

        // clear the value of the fields
        public void clearFields()
        {
            editBookDBTbxBookID.Text = string.Empty;
            editBookDBTbxTitle.Text = string.Empty;
            editBookDBTbxAuthor.Text = string.Empty;
            editBookDBTbxPublisher.Text = string.Empty;
            editBookDBTbxYop.Text = string.Empty;
            editBookDBTbxGenres.Text = string.Empty;
            pictureBox1.Image = null;
        }

        public admEditBookDB()
        {
            InitializeComponent();
        }

        private void admEditBookDBBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admEditBookDBBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        // search the book DB functionality
        private void editBookDBBtnSearch_Click(object sender, EventArgs e)
        {

            if (admEditBookDBRbBoth.Checked == true)
            {
                //cmd = new SqlCommand("select * from books where title like @searchQuery or author like @searchQuery", con);
                //cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds);

                //editBookDBDgvTable.DataSource = ds.Tables[0];

            }
            else if (admEditBookDBRbTitle.Checked == true)
            {
                string query = "SELECT * FROM Sach Where TieuDe = '" + editBookDBTbxSearch.Text.Trim() + "'  ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                editBookDBDgvTable.DataSource = BookTable.ToList();

            }
            else if (admEditBookDBRbAuthor.Checked == true)
            {
                string query = "SELECT * FROM Sach Where TacGia = '" + editBookDBTbxSearch.Text.Trim() + "'  ALLOW FILTERING";

                var BookTable = DataConnection.Ins.session.Execute(query)
                    .Select(BookSelector);

                editBookDBDgvTable.DataSource = BookTable.ToList();

            }
        }

        private void admEditBookDBBtnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Clicking cell of datagridview
        private void editBookDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // remove column headers

                if (e.RowIndex != -1 && e.RowIndex != editBookDBDgvTable.Rows.Count)
                {
                    // copy value to variable even if unnecessary
                    selected_book_id = Convert.ToInt32(editBookDBDgvTable.Rows[e.RowIndex].Cells[0].Value);
                    string title = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[1].Value);
                    string author = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[4].Value);
                    string publisher = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[2].Value);
                    string year_of_pub = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[5].Value);
                    string genres = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[3].Value);

                    // paste into textbox
                    editBookDBTbxBookID.Text = Convert.ToString(selected_book_id);
                    editBookDBTbxTitle.Text = title;
                    editBookDBTbxAuthor.Text = author;
                    editBookDBTbxPublisher.Text = publisher;
                    editBookDBTbxYop.Text = Convert.ToString(year_of_pub);
                    editBookDBTbxGenres.Text = genres;



                    string booksquery = "SELECT picture FROM books where id = " + selected_book_id + " ALLOW FILTERING;";
                    var bookresults = DataConnection.Ins.session.Execute(booksquery).FirstOrDefault();
                    tb.Data = bookresults.GetValue<byte[]>("picture");
                    tb.convertImgFromByte();
                    pictureBox1.Image = tb.Img;
                }

            }
            catch
            {

            }

        }

        // SAVE EDIT BUTTON
        private void editBookDBBtnSave_Click(object sender, EventArgs e)
        {
            if (editBookDBTbxTitle.Text.Trim() == string.Empty || editBookDBTbxGenres.Text.Trim() == string.Empty || editBookDBTbxBookID.Text.Trim() == string.Empty || editBookDBTbxPublisher.Text.Trim() == string.Empty || editBookDBTbxYop.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Các trường thông tin không được thiếu");
            }

            try
            {
                tblBook tk = new tblBook();

                tk.Id = Convert.ToInt32(editBookDBTbxBookID.Text);
                tk.Genres = editBookDBTbxGenres.Text;
                tk.Author = editBookDBTbxAuthor.Text;
                tk.Publisher = editBookDBTbxPublisher.Text;
                tk.PublishYear = editBookDBTbxYop.Text;
                tk.Title = editBookDBTbxTitle.Text;
                tk.Status = 0;
                tk.UserEmail = "";
                tk.UserId = 0;
                tk.DateIssue = DateTime.Now;

                int issueyear = tk.DateIssue.Year;
                int issuemonth = tk.DateIssue.Month;
                int issday = tk.DateIssue.Day;

                var ps = DataConnection.Ins.session.Prepare("update books set title=? , publisher=? , genres=?, author=?, publishYear=? ,status=? , userId=?,userEmail =?,dateIssue =?, picture=? where id=?;");
                var query = ps.Bind(tk.Title, tk.Publisher, tk.Genres, tk.Author, tk.PublishYear, tk.Status, tk.UserId, tk.UserEmail, new DateTime(issueyear, issuemonth, issday), tb.Data, tk.Id);
                DataConnection.Ins.session.Execute(query);
                displayBooks();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // ADD TO DB BUTTON
        private void editBookDBBtnAddToDB_Click(object sender, EventArgs e)
        {
            try
            {
                tblBook tk = new tblBook();
                tk.Id = Convert.ToInt32(editBookDBTbxBookID.Text);
                tk.Genres = editBookDBTbxGenres.Text;
                tk.Author = editBookDBTbxAuthor.Text;
                tk.Publisher = editBookDBTbxPublisher.Text;
                tk.PublishYear = editBookDBTbxYop.Text;
                tk.Title = editBookDBTbxTitle.Text;
                tk.Status = 0;
                tk.UserEmail = "";
                tk.UserId = 0;
                tk.DateIssue = DateTime.Now;

                int issueyear = tk.DateIssue.Year;
                int issuemonth = tk.DateIssue.Month;
                int issday = tk.DateIssue.Day;

                var ps = DataConnection.Ins.session.Prepare("insert into  books (id ,title,publisher,genres,author,publishYear,status,userId,userEmail,dateIssue,picture) values (?,?,?,?,?,?,?,?,?,?,?);");
                var query = ps.Bind(tk.Id, tk.Title, tk.Publisher, tk.Genres, tk.Author, tk.PublishYear, tk.Status, tk.UserId, tk.UserEmail, new DateTime(issueyear, issuemonth, issday), tb.Data);
                DataConnection.Ins.session.Execute(query);

                clearFields();
                displayBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // DELETE BUTTON
        private void editBookDBBtnDelete_Click(object sender, EventArgs e)
        {
            // variables 
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            try
            {
                book_id = selected_book_id;
            }
            catch
            {
                MessageBox.Show("Id sách phải là số.");
                preliminaryAcceptedState = false;
            }

            if (preliminaryAcceptedState == true)
            {
                try
                {

                    tblBook tk = new tblBook();
                    tk.Id = book_id;

                    var ps = DataConnection.Ins.session.Prepare("DELETE from books WHERE id=? ");
                    var query = ps.Bind(tk.Id);
                    DataConnection.Ins.session.Execute(query);

                    clearFields();
                    // display updated books
                    displayBooks();
                    MessageBox.Show("Book successfully deleted.");

                }
                catch
                {
                    MessageBox.Show("Không thể xoá sách đang mượn.");
                }
            }
        }

        private void admEditBookDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPickImage_Click(object sender, EventArgs e)
        {
            tb.chooseImg();
            pictureBox1.Image = tb.Img;
        }
    }
}
