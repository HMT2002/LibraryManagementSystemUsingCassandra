namespace LibraryManagementSystem
{
    partial class admReturn
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
            this.admReturnBooksBtnLogout = new System.Windows.Forms.Button();
            this.admReturnBooksBtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.admReturnBtnSearch = new System.Windows.Forms.Button();
            this.admReturnTbxSearchQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchLblSearch = new System.Windows.Forms.Label();
            this.admReturnDgvTable = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.admReturnBtnReturn = new System.Windows.Forms.Button();
            this.admReturnTbxUserID = new System.Windows.Forms.TextBox();
            this.amdReturnTbxBookID = new System.Windows.Forms.TextBox();
            this.admReturnLblUserID = new System.Windows.Forms.Label();
            this.admReturnLblBookID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.admReturnDgvTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // admReturnBooksBtnLogout
            // 
            this.admReturnBooksBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBooksBtnLogout.Location = new System.Drawing.Point(918, 21);
            this.admReturnBooksBtnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnBooksBtnLogout.Name = "admReturnBooksBtnLogout";
            this.admReturnBooksBtnLogout.Size = new System.Drawing.Size(141, 37);
            this.admReturnBooksBtnLogout.TabIndex = 68;
            this.admReturnBooksBtnLogout.Text = "Đăng xuất";
            this.admReturnBooksBtnLogout.UseVisualStyleBackColor = true;
            this.admReturnBooksBtnLogout.Click += new System.EventHandler(this.admReturnBooksBtnLogout_Click);
            // 
            // admReturnBooksBtnBack
            // 
            this.admReturnBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBooksBtnBack.Location = new System.Drawing.Point(33, 21);
            this.admReturnBooksBtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnBooksBtnBack.Name = "admReturnBooksBtnBack";
            this.admReturnBooksBtnBack.Size = new System.Drawing.Size(103, 37);
            this.admReturnBooksBtnBack.TabIndex = 67;
            this.admReturnBooksBtnBack.Text = "Quay lại";
            this.admReturnBooksBtnBack.UseVisualStyleBackColor = true;
            this.admReturnBooksBtnBack.Click += new System.EventHandler(this.admReturnBooksBtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "(Chỉ hiện sách đã được mượn)";
            // 
            // admReturnBtnSearch
            // 
            this.admReturnBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnBtnSearch.Location = new System.Drawing.Point(736, 455);
            this.admReturnBtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnBtnSearch.Name = "admReturnBtnSearch";
            this.admReturnBtnSearch.Size = new System.Drawing.Size(117, 41);
            this.admReturnBtnSearch.TabIndex = 64;
            this.admReturnBtnSearch.Text = "Tìm";
            this.admReturnBtnSearch.UseVisualStyleBackColor = true;
            this.admReturnBtnSearch.Click += new System.EventHandler(this.admReturnBtnSearch_Click);
            // 
            // admReturnTbxSearchQuery
            // 
            this.admReturnTbxSearchQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnTbxSearchQuery.Location = new System.Drawing.Point(265, 419);
            this.admReturnTbxSearchQuery.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnTbxSearchQuery.Name = "admReturnTbxSearchQuery";
            this.admReturnTbxSearchQuery.Size = new System.Drawing.Size(587, 26);
            this.admReturnTbxSearchQuery.TabIndex = 63;
            // 
            // admBookSearchLblSearch
            // 
            this.admBookSearchLblSearch.AutoSize = true;
            this.admBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchLblSearch.Location = new System.Drawing.Point(55, 423);
            this.admBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admBookSearchLblSearch.Name = "admBookSearchLblSearch";
            this.admBookSearchLblSearch.Size = new System.Drawing.Size(89, 25);
            this.admBookSearchLblSearch.TabIndex = 59;
            this.admBookSearchLblSearch.Text = "ID sách :";
            // 
            // admReturnDgvTable
            // 
            this.admReturnDgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admReturnDgvTable.Location = new System.Drawing.Point(33, 548);
            this.admReturnDgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnDgvTable.Name = "admReturnDgvTable";
            this.admReturnDgvTable.RowHeadersWidth = 51;
            this.admReturnDgvTable.Size = new System.Drawing.Size(1025, 368);
            this.admReturnDgvTable.TabIndex = 58;
            this.admReturnDgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.admReturnDgvTable_CellClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(33, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1025, 2);
            this.label7.TabIndex = 57;
            // 
            // admReturnBtnReturn
            // 
            this.admReturnBtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnBtnReturn.Location = new System.Drawing.Point(492, 125);
            this.admReturnBtnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnBtnReturn.Name = "admReturnBtnReturn";
            this.admReturnBtnReturn.Size = new System.Drawing.Size(128, 41);
            this.admReturnBtnReturn.TabIndex = 19;
            this.admReturnBtnReturn.Text = "Trả sách";
            this.admReturnBtnReturn.UseVisualStyleBackColor = true;
            this.admReturnBtnReturn.Click += new System.EventHandler(this.admReturnBtnReturn_Click);
            // 
            // admReturnTbxUserID
            // 
            this.admReturnTbxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnTbxUserID.Location = new System.Drawing.Point(499, 80);
            this.admReturnTbxUserID.Margin = new System.Windows.Forms.Padding(4);
            this.admReturnTbxUserID.Name = "admReturnTbxUserID";
            this.admReturnTbxUserID.Size = new System.Drawing.Size(200, 37);
            this.admReturnTbxUserID.TabIndex = 18;
            // 
            // amdReturnTbxBookID
            // 
            this.amdReturnTbxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.amdReturnTbxBookID.Location = new System.Drawing.Point(499, 23);
            this.amdReturnTbxBookID.Margin = new System.Windows.Forms.Padding(4);
            this.amdReturnTbxBookID.Name = "amdReturnTbxBookID";
            this.amdReturnTbxBookID.Size = new System.Drawing.Size(200, 37);
            this.amdReturnTbxBookID.TabIndex = 17;
            // 
            // admReturnLblUserID
            // 
            this.admReturnLblUserID.AutoSize = true;
            this.admReturnLblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.admReturnLblUserID.Location = new System.Drawing.Point(294, 86);
            this.admReturnLblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admReturnLblUserID.Name = "admReturnLblUserID";
            this.admReturnLblUserID.Size = new System.Drawing.Size(197, 31);
            this.admReturnLblUserID.TabIndex = 16;
            this.admReturnLblUserID.Text = "ID người dùng: ";
            // 
            // admReturnLblBookID
            // 
            this.admReturnLblBookID.AutoSize = true;
            this.admReturnLblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admReturnLblBookID.Location = new System.Drawing.Point(289, 29);
            this.admReturnLblBookID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.admReturnLblBookID.Name = "admReturnLblBookID";
            this.admReturnLblBookID.Size = new System.Drawing.Size(122, 31);
            this.admReturnLblBookID.TabIndex = 15;
            this.admReturnLblBookID.Text = "ID sách: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBoxBook);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Controls.Add(this.admReturnBooksBtnLogout);
            this.panel1.Controls.Add(this.admReturnBooksBtnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admReturnBtnSearch);
            this.panel1.Controls.Add(this.admReturnTbxSearchQuery);
            this.panel1.Controls.Add(this.admBookSearchLblSearch);
            this.panel1.Controls.Add(this.admReturnDgvTable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.admReturnBtnReturn);
            this.panel1.Controls.Add(this.admReturnTbxUserID);
            this.panel1.Controls.Add(this.amdReturnTbxBookID);
            this.panel1.Controls.Add(this.admReturnLblUserID);
            this.panel1.Controls.Add(this.admReturnLblBookID);
            this.panel1.Location = new System.Drawing.Point(51, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 944);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUser.Location = new System.Drawing.Point(828, 166);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(230, 175);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 71;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBook.Location = new System.Drawing.Point(60, 166);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(230, 175);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBook.TabIndex = 72;
            this.pictureBoxBook.TabStop = false;
            // 
            // admReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 974);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admReturn";
            this.Text = "Return Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admReturn_FormClosing);
            this.Load += new System.EventHandler(this.admReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admReturnDgvTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admReturnBooksBtnLogout;
        private System.Windows.Forms.Button admReturnBooksBtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admReturnBtnSearch;
        private System.Windows.Forms.TextBox admReturnTbxSearchQuery;
        private System.Windows.Forms.Label admBookSearchLblSearch;
        private System.Windows.Forms.DataGridView admReturnDgvTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button admReturnBtnReturn;
        private System.Windows.Forms.TextBox admReturnTbxUserID;
        private System.Windows.Forms.TextBox amdReturnTbxBookID;
        private System.Windows.Forms.Label admReturnLblUserID;
        private System.Windows.Forms.Label admReturnLblBookID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.PictureBox pictureBoxUser;
    }
}