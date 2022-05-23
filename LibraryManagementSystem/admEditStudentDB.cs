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

namespace LibraryManagementSystem
{
    public partial class admEditStudentDB : Form
    {
        private readonly IMapper mapper = new Mapper(DataConnection.Ins.session);

        // selected book id
        int selected_user_id;

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
            string query = "Select * from Users";
            List<User> users = mapper.Fetch<User>(query).ToList();
            editStudentDBDgvTable.DataSource = users;
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
                string email = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[1].Value);
                string password = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[2].Value);
                string name = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[3].Value);
                string address = Convert.ToString(editStudentDBDgvTable.Rows[e.RowIndex].Cells[4].Value);
                bool type = Convert.ToBoolean(editStudentDBDgvTable.Rows[e.RowIndex].Cells[5].Value);

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
                string query = String.Format("insert into users(id, email, password, name, address, type) values ({0},'{1}','{2}','{3}','{4}',{5})", user_id, email, password, name, address, type);
                Cassandra.RowSet row = DataConnection.Ins.session.Execute(query);
                MessageBox.Show("Changes successfully saved.");
                clearFields();
                displayUsers();
            }
            catch
            {
                MessageBox.Show("Something wrong!!!");
            }
        }

        private void editStudentDBBtnDelete_Click(object sender, EventArgs e)
        {
            //need to do
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
