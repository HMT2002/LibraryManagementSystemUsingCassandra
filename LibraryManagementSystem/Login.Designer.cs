﻿namespace LibraryManagementSystem
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBtnSubmit = new System.Windows.Forms.Button();
            this.loginTbxPassword = new System.Windows.Forms.TextBox();
            this.loginTbxUserId = new System.Windows.Forms.TextBox();
            this.loginLblPassword = new System.Windows.Forms.Label();
            this.loginLblUserId = new System.Windows.Forms.Label();
            this.loginLblQuote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LoginBtnSubmit);
            this.panel1.Controls.Add(this.loginTbxPassword);
            this.panel1.Controls.Add(this.loginTbxUserId);
            this.panel1.Controls.Add(this.loginLblPassword);
            this.panel1.Controls.Add(this.loginLblUserId);
            this.panel1.Controls.Add(this.loginLblQuote);
            this.panel1.Location = new System.Drawing.Point(89, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 688);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(901, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // LoginBtnSubmit
            // 
            this.LoginBtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtnSubmit.Location = new System.Drawing.Point(565, 375);
            this.LoginBtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtnSubmit.Name = "LoginBtnSubmit";
            this.LoginBtnSubmit.Size = new System.Drawing.Size(142, 39);
            this.LoginBtnSubmit.TabIndex = 9;
            this.LoginBtnSubmit.Text = "Đăng nhập";
            this.LoginBtnSubmit.UseVisualStyleBackColor = true;
            this.LoginBtnSubmit.Click += new System.EventHandler(this.LoginBtnSubmit_Click);
            // 
            // loginTbxPassword
            // 
            this.loginTbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTbxPassword.Location = new System.Drawing.Point(472, 315);
            this.loginTbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.loginTbxPassword.Name = "loginTbxPassword";
            this.loginTbxPassword.PasswordChar = '*';
            this.loginTbxPassword.Size = new System.Drawing.Size(391, 32);
            this.loginTbxPassword.TabIndex = 8;
            // 
            // loginTbxUserId
            // 
            this.loginTbxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTbxUserId.Location = new System.Drawing.Point(472, 260);
            this.loginTbxUserId.Margin = new System.Windows.Forms.Padding(4);
            this.loginTbxUserId.Name = "loginTbxUserId";
            this.loginTbxUserId.Size = new System.Drawing.Size(391, 32);
            this.loginTbxUserId.TabIndex = 7;
            // 
            // loginLblPassword
            // 
            this.loginLblPassword.AutoSize = true;
            this.loginLblPassword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblPassword.Location = new System.Drawing.Point(283, 319);
            this.loginLblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLblPassword.Name = "loginLblPassword";
            this.loginLblPassword.Size = new System.Drawing.Size(129, 28);
            this.loginLblPassword.TabIndex = 6;
            this.loginLblPassword.Text = "Mật khẩu:";
            // 
            // loginLblUserId
            // 
            this.loginLblUserId.AutoSize = true;
            this.loginLblUserId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblUserId.Location = new System.Drawing.Point(283, 264);
            this.loginLblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLblUserId.Name = "loginLblUserId";
            this.loginLblUserId.Size = new System.Drawing.Size(181, 28);
            this.loginLblUserId.TabIndex = 5;
            this.loginLblUserId.Text = "Tên đăng nhập";
            // 
            // loginLblQuote
            // 
            this.loginLblQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginLblQuote.AutoSize = true;
            this.loginLblQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblQuote.Location = new System.Drawing.Point(520, 128);
            this.loginLblQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLblQuote.Name = "loginLblQuote";
            this.loginLblQuote.Size = new System.Drawing.Size(255, 45);
            this.loginLblQuote.TabIndex = 3;
            this.loginLblQuote.Text = "Thư viện SE301";
            this.loginLblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLblQuote.UseCompatibleTextRendering = true;
            // 
            // login
            // 
            this.AcceptButton = this.LoginBtnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 785);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLblQuote;
        private System.Windows.Forms.Button LoginBtnSubmit;
        private System.Windows.Forms.TextBox loginTbxPassword;
        private System.Windows.Forms.TextBox loginTbxUserId;
        private System.Windows.Forms.Label loginLblPassword;
        private System.Windows.Forms.Label loginLblUserId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

