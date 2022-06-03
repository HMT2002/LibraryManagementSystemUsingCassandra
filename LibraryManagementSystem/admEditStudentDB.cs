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
using Cassandra.Mapping;
using LibraryManagementSystem.Model;
using Cassandra;

namespace LibraryManagementSystem
{
    public partial class admEditStudentDB : Form
    {
        private readonly IMapper mapper = new Mapper(DataConnection.Ins.session);

        // selected book id
        int selected_user_id;


        Func<Row, tblStudent> StudentSelector;

        private void admEditStudentDB_Load(object sender, EventArgs e)
        {
            // display table
            displayUsers();
        }

        public admEditStudentDB()
        {
            InitializeComponent();


        }

        public void displayUsers()
        {
            //string query = "Select * from Users";
            //List<User> users = mapper.Fetch<User>(query).ToList();
            //editStudentDBDgvTable.DataSource = users;

            StudentSelector = delegate (Row r)
            {
                tblStudent card = new tblStudent
                {
                    Id = r.GetValue<int>("id"),
                    Name = r.GetValue<string>("name"),
                    Email = r.GetValue<string>("email"),
                    Type = r.GetValue<int>("type"),
                    Password = r.GetValue<string>("password"),
                    Address=r.GetValue<string>("address"),
                };
                return card;
            };


            string query = "SELECT * FROM users";

            var BookTable = DataConnection.Ins.session.Execute(query)
                .Select(StudentSelector);

            editStudentDBDgvTable.DataSource = BookTable.ToList();
            editStudentDBDgvTable.ReadOnly = true;
            editStudentDBDgvTable.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        public void clearFields()
        {
            editStudentDBTbxUserID.Text = string.Empty;
            admStudentDBTbxName.Text = string.Empty;
            editStudentDBTbxAddress.Text = string.Empty;
            editStudentDBTbxPassword.Text = string.Empty;
            editStudentDBTbxEmail.Text = string.Empty;
            admStudentDBCbAdmin.Checked = false;
        }

        private void editStudentDBBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void editStudentDBBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        // search functionality
        private void editStudentDBBtnSearch_Click(object sender, EventArgs e)
        {
            //need to do
        }

        // cell click event
        private void editStudentDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // remove column headers
            if (e.RowIndex != -1)
            {
                // copy value to variable even if unnecessary
                selected_user_id = Convert.ToInt32(editStudentDBDgvTable.Rows[e.RowIndex].Cells[0].Value);
                string email = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[3].Value);
                string password = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[5].Value);
                string name = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[1].Value);
                string address = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[2].Value);
                bool type = Convert.ToBoolean(editStudentDBDgvTable.Rows[e.RowIndex].Cells[4].Value);

                // paste into textbox
                editStudentDBTbxUserID.Text = Convert.ToString(selected_user_id);
                admStudentDBCbAdmin.Checked = type;
                admStudentDBTbxName.Text = name;
                editStudentDBTbxAddress.Text = address;
                editStudentDBTbxPassword.Text = password;
                editStudentDBTbxEmail.Text = email;
            }
        }

        // CLEAR BUTTON
        private void admEditStudentDBBtnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // SAVE EDIT BUTTON
        private void editStudentDBBtnSave_Click(object sender, EventArgs e)
        {
            //need to do
            int user_id = 0;
            int type;
            string name;
            string address;
            string password;
            string email;

            user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            type = Convert.ToInt32(admStudentDBCbAdmin.Checked);
            name = admStudentDBTbxName.Text;
            address = editStudentDBTbxAddress.Text;
            password = editStudentDBTbxPassword.Text;
            email = editStudentDBTbxEmail.Text;

            try
            {
                //string query = String.Format("insert into users(id, email, password, name, address, type) values ({0},'{1}','{2}','{3}','{4}',{5})", user_id, email, password, name, address, type);
                //Cassandra.RowSet row = DataConnection.Ins.session.Execute(query);
                //MessageBox.Show("Changes successfully saved.");

                tblStudent tk = new tblStudent();
                tk.Id = user_id;
                tk.Name = name;
                tk.Type = type;
                tk.Email = email;
                tk.Address = address;
                tk.Password = password;

                DateTime time = DateTime.Now;

                int issueyear = time.Year;
                int issuemonth = time.Month;
                int issday = time.Day;

                var ps = DataConnection.Ins.session.Prepare("update users set name=? , email=? , password=?, type=?, address=? where id=?;");
                var query = ps.Bind(tk.Name, tk.Email, tk.Password, tk.Type, tk.Address, tk.Id);
                DataConnection.Ins.session.Execute(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            displayUsers();

        }

        // ADD TO DB BUTTON
        private void editStudentDBBtnAddToDB_Click(object sender, EventArgs e)
        {
            // variables 
            int user_id = 0;
            int type;
            string name;
            string address;
            string password;
            string email;



            user_id = Convert.ToInt32(editStudentDBTbxUserID.Text);
            type = Convert.ToInt32(admStudentDBCbAdmin.Checked);
            name = admStudentDBTbxName.Text;
            address = editStudentDBTbxAddress.Text;
            password = editStudentDBTbxPassword.Text;
            email = editStudentDBTbxEmail.Text;

            try
            {
                //string query = String.Format("insert into users(id, email, password, name, address, type) values ({0},'{1}','{2}','{3}','{4}',{5})", user_id, email, password, name, address, type);
                //Cassandra.RowSet row = DataConnection.Ins.session.Execute(query);
                //MessageBox.Show("Changes successfully saved.");

                tblStudent tk = new tblStudent();
                tk.Id = user_id;
                tk.Name = name;
                tk.Type = type;
                tk.Email = email;
                tk.Address = address;
                tk.Password = password;

                DateTime time = DateTime.Now;

                int issueyear = time.Year;
                int issuemonth = time.Month;
                int issday = time.Day;

                var ps = DataConnection.Ins.session.Prepare("insert into  users (id ,email,password,type,name,address) values (?,?,?,?,?,?);");
                var query = ps.Bind(tk.Id, tk.Email, tk.Password, tk.Type, tk.Name, tk.Address);
                DataConnection.Ins.session.Execute(query);

                clearFields();
                displayUsers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editStudentDBBtnDelete_Click(object sender, EventArgs e)
        {
            //need to do

            int user_id = 0;

            bool preliminaryAcceptedState = true;

            try
            {
                user_id = selected_user_id;
            }
            catch
            {
                MessageBox.Show("Id sách phải là số.");
                preliminaryAcceptedState = false;
            }

            // try to edit book only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    //cmd = new SqlCommand("delete from books where book_id = @book_id", con);
                    //cmd.Parameters.AddWithValue("@book_id", book_id);

                    //int result = cmd.ExecuteNonQuery();

                    tblStudent tk = new tblStudent();
                    tk.Id = user_id;

                    var ps = DataConnection.Ins.session.Prepare("DELETE from users WHERE id=? ");
                    var query = ps.Bind(tk.Id);
                    DataConnection.Ins.session.Execute(query);
                    clearFields();
                    // display updated books
                    displayUsers();
                    MessageBox.Show("users successfully deleted.");

                }
                catch
                {
                    MessageBox.Show("Không thể xoá user.");
                }
            }

        }

        private void admEditStudentDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void editStudentDBTbxUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
