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
using System.Security.Cryptography;
using System.Threading;
namespace LibraryManagementSystem
{
    public partial class login : Form
    {
        // variables
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public static int userid;
        public static string password;

        private void login_Load(object sender, EventArgs e)
        {
        }

        public login()
        {
            InitializeComponent();
        }

        // functions to empty text boxes on login
        public void clear()
        {
            loginTbxUserId.Text = string.Empty;
            loginTbxPassword.Text = string.Empty;
        }

        private void LoginBtnSubmit_Click(object sender, EventArgs e)
        {
            #region prev
            //if (con.State == ConnectionState.Closed)
            //    con.Open();

            //cmd = new SqlCommand("select * from users where user_id = @user_id and password = @password", con);
            //cmd.Parameters.AddWithValue("@user_id", loginTbxUserId.Text);
            //cmd.Parameters.AddWithValue("@password", loginTbxPassword.Text);

            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();

            //sda.Fill(dt);

            //if (dt.Rows.Count > 0)
            //{
            //    // successfully logged in pass userid and pwd
            //    userid = Convert.ToInt32(loginTbxUserId.Text);
            //    password = loginTbxPassword.Text;

            //    if (Convert.ToString(dt.Rows[0][1]) == "False")
            //    {
            //        this.Hide();
            //        userBookSearch ubs = new userBookSearch();
            //        ubs.Show();
            //    }
            //    else
            //    {
            //        this.Hide();
            //        admStartPage asp = new admStartPage();
            //        asp.Show();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("The entered USER ID or PASSWORD is WRONG.\nPlease check and try again.\nIf you have forgotten the password then go to the librarian to create a new one.");
            //    clear();
            //}
            #endregion
            string query = "Select * from User Where Email ='" + loginTbxUserId.Text.Trim() + "' and Password = '" + loginTbxPassword.Text.Trim() + "'  ALLOW FILTERING";

            Cassandra.RowSet row = DataConnection.Ins.session.Execute(query);
            if (row.FirstOrDefault() != null)
            {
                this.Hide();
                admStartPage menuF = new admStartPage();
                menuF.Show();
            }
            else
            {
                MessageBox.Show("Wrong email or password!!!!");
            }
        }

        public bool Login()
        {
            string query = "Select * from User Where Email ='" + userid + "' and Password = '" + password + "'  ALLOW FILTERING";
            Cassandra.RowSet row = DataConnection.Ins.session.Execute(query);

            if (row.FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
