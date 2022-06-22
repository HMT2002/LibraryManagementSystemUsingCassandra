namespace LibraryManagementSystem
{
    partial class userBookSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usrBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.UserBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.UserBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.userBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.userBookSearchLblSearch = new System.Windows.Forms.Label();
            this.userBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.usrBookSearchBtnLogout);
            this.panel1.Controls.Add(this.UserBookSearchBtnSearch);
            this.panel1.Controls.Add(this.UserBookSearchTbxQuery);
            this.panel1.Controls.Add(this.userBookSearchRbAuthor);
            this.panel1.Controls.Add(this.userBookSearchRbTitle);
            this.panel1.Controls.Add(this.userBookSearchLblSearch);
            this.panel1.Controls.Add(this.userBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(57, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1703, 889);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(1204, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "Những cuốn đã được mượn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.usrBookSearchBtnIssuedBooks_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1307, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.userBookSeacrhBtnChangePassword_Click);
            // 
            // usrBookSearchBtnLogout
            // 
            this.usrBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrBookSearchBtnLogout.Location = new System.Drawing.Point(1363, 105);
            this.usrBookSearchBtnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.usrBookSearchBtnLogout.Name = "usrBookSearchBtnLogout";
            this.usrBookSearchBtnLogout.Size = new System.Drawing.Size(138, 43);
            this.usrBookSearchBtnLogout.TabIndex = 21;
            this.usrBookSearchBtnLogout.Text = "Đăng xuất";
            this.usrBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.usrBookSearchBtnLogout.Click += new System.EventHandler(this.UserBookSearchBtnLogout_Click);
            // 
            // UserBookSearchBtnSearch
            // 
            this.UserBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchBtnSearch.Location = new System.Drawing.Point(613, 149);
            this.UserBookSearchBtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.UserBookSearchBtnSearch.Name = "UserBookSearchBtnSearch";
            this.UserBookSearchBtnSearch.Size = new System.Drawing.Size(117, 41);
            this.UserBookSearchBtnSearch.TabIndex = 19;
            this.UserBookSearchBtnSearch.Text = "Tìm";
            this.UserBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.UserBookSearchBtnSearch.Click += new System.EventHandler(this.UserBookSearchBtnSearch_Click);
            // 
            // UserBookSearchTbxQuery
            // 
            this.UserBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchTbxQuery.Location = new System.Drawing.Point(295, 113);
            this.UserBookSearchTbxQuery.Margin = new System.Windows.Forms.Padding(4);
            this.UserBookSearchTbxQuery.Name = "UserBookSearchTbxQuery";
            this.UserBookSearchTbxQuery.Size = new System.Drawing.Size(435, 26);
            this.UserBookSearchTbxQuery.TabIndex = 18;
            // 
            // userBookSearchRbAuthor
            // 
            this.userBookSearchRbAuthor.AutoSize = true;
            this.userBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbAuthor.Location = new System.Drawing.Point(418, 149);
            this.userBookSearchRbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.userBookSearchRbAuthor.Name = "userBookSearchRbAuthor";
            this.userBookSearchRbAuthor.Size = new System.Drawing.Size(98, 29);
            this.userBookSearchRbAuthor.TabIndex = 16;
            this.userBookSearchRbAuthor.TabStop = true;
            this.userBookSearchRbAuthor.Text = "Tác giả";
            this.userBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbTitle
            // 
            this.userBookSearchRbTitle.AutoSize = true;
            this.userBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbTitle.Location = new System.Drawing.Point(295, 149);
            this.userBookSearchRbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.userBookSearchRbTitle.Name = "userBookSearchRbTitle";
            this.userBookSearchRbTitle.Size = new System.Drawing.Size(99, 29);
            this.userBookSearchRbTitle.TabIndex = 15;
            this.userBookSearchRbTitle.TabStop = true;
            this.userBookSearchRbTitle.Text = "Tiêu đề";
            this.userBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // userBookSearchLblSearch
            // 
            this.userBookSearchLblSearch.AutoSize = true;
            this.userBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchLblSearch.Location = new System.Drawing.Point(185, 114);
            this.userBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userBookSearchLblSearch.Name = "userBookSearchLblSearch";
            this.userBookSearchLblSearch.Size = new System.Drawing.Size(102, 25);
            this.userBookSearchLblSearch.TabIndex = 14;
            this.userBookSearchLblSearch.Text = "Tìm kiếm: ";
            // 
            // userBookSearchDgv
            // 
            this.userBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookSearchDgv.Location = new System.Drawing.Point(209, 255);
            this.userBookSearchDgv.Margin = new System.Windows.Forms.Padding(4);
            this.userBookSearchDgv.Name = "userBookSearchDgv";
            this.userBookSearchDgv.RowHeadersWidth = 51;
            this.userBookSearchDgv.Size = new System.Drawing.Size(1292, 592);
            this.userBookSearchDgv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "(Chỉ hiển thị sách chưa được mượn)";
            // 
            // userBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 961);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userBookSearch";
            this.Text = "Search Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userBookSearch_FormClosing);
            this.Load += new System.EventHandler(this.userBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usrBookSearchBtnLogout;
        private System.Windows.Forms.Button UserBookSearchBtnSearch;
        private System.Windows.Forms.TextBox UserBookSearchTbxQuery;
        private System.Windows.Forms.RadioButton userBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton userBookSearchRbTitle;
        private System.Windows.Forms.Label userBookSearchLblSearch;
        private System.Windows.Forms.DataGridView userBookSearchDgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}