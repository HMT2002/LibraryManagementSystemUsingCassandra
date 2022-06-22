namespace LibraryManagementSystem
{
    partial class usrIssuedBooks
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
            this.usrIssuedBooksBtnBack = new System.Windows.Forms.Button();
            this.usrIssuedBooksDgvBooks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrIssuedBooksDgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.usrIssuedBooksBtnBack);
            this.panel1.Controls.Add(this.usrIssuedBooksDgvBooks);
            this.panel1.Location = new System.Drawing.Point(31, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 788);
            this.panel1.TabIndex = 0;
            // 
            // usrIssuedBooksBtnBack
            // 
            this.usrIssuedBooksBtnBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usrIssuedBooksBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrIssuedBooksBtnBack.Location = new System.Drawing.Point(1231, 34);
            this.usrIssuedBooksBtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.usrIssuedBooksBtnBack.Name = "usrIssuedBooksBtnBack";
            this.usrIssuedBooksBtnBack.Size = new System.Drawing.Size(141, 50);
            this.usrIssuedBooksBtnBack.TabIndex = 3;
            this.usrIssuedBooksBtnBack.Text = "Quay lại";
            this.usrIssuedBooksBtnBack.UseVisualStyleBackColor = true;
            this.usrIssuedBooksBtnBack.Click += new System.EventHandler(this.usrIssuedBooksBtnBack_Click);
            // 
            // usrIssuedBooksDgvBooks
            // 
            this.usrIssuedBooksDgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usrIssuedBooksDgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.usrIssuedBooksDgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usrIssuedBooksDgvBooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.usrIssuedBooksDgvBooks.Location = new System.Drawing.Point(25, 126);
            this.usrIssuedBooksDgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.usrIssuedBooksDgvBooks.Name = "usrIssuedBooksDgvBooks";
            this.usrIssuedBooksDgvBooks.RowHeadersWidth = 51;
            this.usrIssuedBooksDgvBooks.RowTemplate.Height = 30;
            this.usrIssuedBooksDgvBooks.Size = new System.Drawing.Size(1379, 628);
            this.usrIssuedBooksDgvBooks.TabIndex = 2;
            // 
            // usrIssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 860);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usrIssuedBooks";
            this.Text = "Issued Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.usrIssuedBooks_FormClosing);
            this.Load += new System.EventHandler(this.usrIssuedBooks_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usrIssuedBooksDgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usrIssuedBooksBtnBack;
        private System.Windows.Forms.DataGridView usrIssuedBooksDgvBooks;
    }
}