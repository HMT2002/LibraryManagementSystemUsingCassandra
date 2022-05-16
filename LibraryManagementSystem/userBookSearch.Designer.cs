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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usrBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.UserBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.UserBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.userBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.userBookSearchLblSearch = new System.Windows.Forms.Label();
            this.userBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.usrBookSearchBtnLogout);
            this.panel1.Controls.Add(this.UserBookSearchBtnSearch);
            this.panel1.Controls.Add(this.UserBookSearchTbxQuery);
            this.panel1.Controls.Add(this.userBookSearchRbBoth);
            this.panel1.Controls.Add(this.userBookSearchRbAuthor);
            this.panel1.Controls.Add(this.userBookSearchRbTitle);
            this.panel1.Controls.Add(this.userBookSearchLblSearch);
            this.panel1.Controls.Add(this.userBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(57, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1703, 889);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(1307, 204);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 43);
            this.button2.TabIndex = 23;
            this.button2.Text = "Issued Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.usrBookSearchBtnIssuedBooks_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1307, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.userBookSeacrhBtnChangePassword_Click);
            // 
            // usrBookSearchBtnLogout
            // 
            this.usrBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrBookSearchBtnLogout.Location = new System.Drawing.Point(1401, 105);
            this.usrBookSearchBtnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrBookSearchBtnLogout.Name = "usrBookSearchBtnLogout";
            this.usrBookSearchBtnLogout.Size = new System.Drawing.Size(100, 43);
            this.usrBookSearchBtnLogout.TabIndex = 21;
            this.usrBookSearchBtnLogout.Text = "Logout";
            this.usrBookSearchBtnLogout.UseVisualStyleBackColor = true;
            this.usrBookSearchBtnLogout.Click += new System.EventHandler(this.UserBookSearchBtnLogout_Click);
            // 
            // UserBookSearchBtnSearch
            // 
            this.UserBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchBtnSearch.Location = new System.Drawing.Point(613, 149);
            this.UserBookSearchBtnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserBookSearchBtnSearch.Name = "UserBookSearchBtnSearch";
            this.UserBookSearchBtnSearch.Size = new System.Drawing.Size(117, 41);
            this.UserBookSearchBtnSearch.TabIndex = 19;
            this.UserBookSearchBtnSearch.Text = "Search";
            this.UserBookSearchBtnSearch.UseVisualStyleBackColor = true;
            this.UserBookSearchBtnSearch.Click += new System.EventHandler(this.UserBookSearchBtnSearch_Click);
            // 
            // UserBookSearchTbxQuery
            // 
            this.UserBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchTbxQuery.Location = new System.Drawing.Point(295, 113);
            this.UserBookSearchTbxQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserBookSearchTbxQuery.Name = "UserBookSearchTbxQuery";
            this.UserBookSearchTbxQuery.Size = new System.Drawing.Size(435, 26);
            this.UserBookSearchTbxQuery.TabIndex = 18;
            // 
            // userBookSearchRbBoth
            // 
            this.userBookSearchRbBoth.AutoSize = true;
            this.userBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbBoth.Location = new System.Drawing.Point(485, 149);
            this.userBookSearchRbBoth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBookSearchRbBoth.Name = "userBookSearchRbBoth";
            this.userBookSearchRbBoth.Size = new System.Drawing.Size(73, 29);
            this.userBookSearchRbBoth.TabIndex = 17;
            this.userBookSearchRbBoth.TabStop = true;
            this.userBookSearchRbBoth.Text = "Both";
            this.userBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbAuthor
            // 
            this.userBookSearchRbAuthor.AutoSize = true;
            this.userBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbAuthor.Location = new System.Drawing.Point(377, 149);
            this.userBookSearchRbAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBookSearchRbAuthor.Name = "userBookSearchRbAuthor";
            this.userBookSearchRbAuthor.Size = new System.Drawing.Size(91, 29);
            this.userBookSearchRbAuthor.TabIndex = 16;
            this.userBookSearchRbAuthor.TabStop = true;
            this.userBookSearchRbAuthor.Text = "Author";
            this.userBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbTitle
            // 
            this.userBookSearchRbTitle.AutoSize = true;
            this.userBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbTitle.Location = new System.Drawing.Point(295, 149);
            this.userBookSearchRbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBookSearchRbTitle.Name = "userBookSearchRbTitle";
            this.userBookSearchRbTitle.Size = new System.Drawing.Size(70, 29);
            this.userBookSearchRbTitle.TabIndex = 15;
            this.userBookSearchRbTitle.TabStop = true;
            this.userBookSearchRbTitle.Text = "Title";
            this.userBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // userBookSearchLblSearch
            // 
            this.userBookSearchLblSearch.AutoSize = true;
            this.userBookSearchLblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchLblSearch.Location = new System.Drawing.Point(201, 117);
            this.userBookSearchLblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userBookSearchLblSearch.Name = "userBookSearchLblSearch";
            this.userBookSearchLblSearch.Size = new System.Drawing.Size(81, 25);
            this.userBookSearchLblSearch.TabIndex = 14;
            this.userBookSearchLblSearch.Text = "Search:";
            // 
            // userBookSearchDgv
            // 
            this.userBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookSearchDgv.Location = new System.Drawing.Point(209, 255);
            this.userBookSearchDgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBookSearchDgv.Name = "userBookSearchDgv";
            this.userBookSearchDgv.RowHeadersWidth = 51;
            this.userBookSearchDgv.Size = new System.Drawing.Size(1292, 592);
            this.userBookSearchDgv.TabIndex = 13;
            // 
            // userBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 961);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton userBookSearchRbBoth;
        private System.Windows.Forms.RadioButton userBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton userBookSearchRbTitle;
        private System.Windows.Forms.Label userBookSearchLblSearch;
        private System.Windows.Forms.DataGridView userBookSearchDgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}