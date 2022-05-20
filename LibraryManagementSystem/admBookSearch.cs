﻿using System;
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
    public partial class admBookSearch : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        Func<Row, tblBook> BookSelector;


        public admBookSearch()
        {
            InitializeComponent();

            BookSelector = delegate (Row r)
            {
                tblBook card = new tblBook
                {
                    MaSach = r.GetValue<string>("masach"),
                    GiaDenBu = r.GetValue<Decimal>("giadenbu"),
                    TacGia = r.GetValue<string>("tacgia"),
                    TheLoai = r.GetValue<string>("theloai"),

                    TieuDe = r.GetValue<string>("tieude"),
                    NgayTra = r.GetValue<DateTime>("ngaytra"),
                    NgayMuon = r.GetValue<DateTime>("ngaymuon"),
                };
                return card;
            };


            string query = "SELECT MaSach, TieuDe, TacGia, TheLoai, NgayMuon, NgayTra, GiaDenBu FROM Sach";

            var TicketTable = DataConnection.Ins.session.Execute(query)
                .Select(BookSelector);

            admBookSearchDgv.DataSource = TicketTable.ToList();

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

                string query = "SELECT * FROM Sach Where TieuDe = '" + admBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

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


                string query = "SELECT * FROM Sach Where TacGia = '" + admBookSearchTbxQuery.Text.Trim() + "'  ALLOW FILTERING";

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
