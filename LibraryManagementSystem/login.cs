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
using Cassandra;
using Cassandra.Mapping;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem
{
    public partial class login : Form
    {
        public static int userid;
        public static string password;
        private readonly IMapper mapper = new Mapper(DataConnection.Ins.session);

        private void login_Load(object sender, EventArgs e)
        {
        }

        public login()
        {
            InitializeComponent();
        }

        public void clear()
        {
            loginTbxUserId.Text = string.Empty;
            loginTbxPassword.Text = string.Empty;
        }

        private void LoginBtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
            string query = "Select * from Users Where Email ='" + loginTbxUserId.Text.Trim() + "' and Password = '" + loginTbxPassword.Text.Trim() + "'  ALLOW FILTERING";

            User user = mapper.Fetch<User>(query).ToList().FirstOrDefault();
            if (user != null)
            {
                userid = user.id;
                password = user.password;
                this.Hide();
                if(user.type == 1)
                {
                    admStartPage menuF = new admStartPage();
                    menuF.Show();
                }else
                {
                    userBookSearch ubs = new userBookSearch();
                    ubs.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong email or password!!!!");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
