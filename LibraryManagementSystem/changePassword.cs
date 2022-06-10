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

namespace LibraryManagementSystem
{
    public partial class changePassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public int userid;
        public string password;

        public changePassword()
        {
            InitializeComponent();
        }

        private void changePassword_Load(object sender, EventArgs e)
        {
            // clear all boxes
            clear();

            // copy pwd and id
            userid = login.userid;
            password = login.password;

            // establish connection to db
        }

        public void clear()
        {
            chnagePassTbxConfirmPass.Text = string.Empty;
            chnagePassTbxCurPass.Text = string.Empty;
            chnagePassTbxNewPass.Text = string.Empty;
        }

        private void chnagePassbtnSubmit_Click(object sender, EventArgs e)
        {
            if(password == chnagePassTbxCurPass.Text)
            {
                if (chnagePassTbxNewPass.Text == chnagePassTbxConfirmPass.Text)
                {

                    var ps = DataConnection.Ins.session.Prepare("update users set password=? where id=?;");
                    var query = ps.Bind(chnagePassTbxConfirmPass.Text.Trim(), userid);
                    DataConnection.Ins.session.Execute(query);

                    // show update
                    MessageBox.Show("Password successfully updated.\nPlease login with the new credentials on the new screen.");

                    // login
                    this.Hide();
                    login lg = new login();
                    lg.Show();
                }
                else
                {
                    MessageBox.Show("Please make sure the new passwords should match.");
                }
            }
            else
            {
                MessageBox.Show("Please make sure the 'current password' matches your current password.");
            }
        }

        private void changePassBtnCancel_Click(object sender, EventArgs e)
        {
            // take back to login screen
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void changePassword_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
