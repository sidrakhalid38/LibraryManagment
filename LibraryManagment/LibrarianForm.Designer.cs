
namespace LibraryManagment
{
    partial class LibrarianForm
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
            this.ilbtxt = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.ilbAuthor = new System.Windows.Forms.Label();
            this.ilbSrNo = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookSrNo = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.ilbQuantity = new System.Windows.Forms.Label();
            this.txtIssueSrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // ilbtxt
            // 
            this.ilbtxt.AutoSize = true;
            this.ilbtxt.Location = new System.Drawing.Point(24, 117);
            this.ilbtxt.Name = "ilbtxt";
            this.ilbtxt.Size = new System.Drawing.Size(34, 20);
            this.ilbtxt.TabIndex = 0;
            this.ilbtxt.Text = "title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(114, 117);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(290, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // ilbAuthor
            // 
            this.ilbAuthor.AutoSize = true;
            this.ilbAuthor.Location = new System.Drawing.Point(24, 163);
            this.ilbAuthor.Name = "ilbAuthor";
            this.ilbAuthor.Size = new System.Drawing.Size(57, 20);
            this.ilbAuthor.TabIndex = 2;
            this.ilbAuthor.Text = "Author";
            // 
            // ilbSrNo
            // 
            this.ilbSrNo.AutoSize = true;
            this.ilbSrNo.Location = new System.Drawing.Point(24, 59);
            this.ilbSrNo.Name = "ilbSrNo";
            this.ilbSrNo.Size = new System.Drawing.Size(45, 20);
            this.ilbSrNo.TabIndex = 3;
            this.ilbSrNo.Text = "SrNo";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(114, 163);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(290, 26);
            this.txtAuthor.TabIndex = 4;
            // 
            // txtBookSrNo
            // 
            this.txtBookSrNo.Location = new System.Drawing.Point(114, 53);
            this.txtBookSrNo.Name = "txtBookSrNo";
            this.txtBookSrNo.Size = new System.Drawing.Size(290, 26);
            this.txtBookSrNo.TabIndex = 5;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(114, 266);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(124, 27);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(262, 266);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(124, 27);
            this.btnDeleteBook.TabIndex = 7;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(427, 44);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.RowTemplate.Height = 28;
            this.dgvBooks.Size = new System.Drawing.Size(513, 209);
            this.dgvBooks.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(114, 218);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(290, 26);
            this.txtQuantity.TabIndex = 10;
            // 
            // ilbQuantity
            // 
            this.ilbQuantity.AutoSize = true;
            this.ilbQuantity.Location = new System.Drawing.Point(24, 224);
            this.ilbQuantity.Name = "ilbQuantity";
            this.ilbQuantity.Size = new System.Drawing.Size(68, 20);
            this.ilbQuantity.TabIndex = 9;
            this.ilbQuantity.Text = "Quantity";
            // 
            // txtIssueSrNo
            // 
            this.txtIssueSrNo.Location = new System.Drawing.Point(133, 394);
            this.txtIssueSrNo.Name = "txtIssueSrNo";
            this.txtIssueSrNo.Size = new System.Drawing.Size(248, 26);
            this.txtIssueSrNo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "SrNo";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(133, 362);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(248, 26);
            this.txtMemberName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Member Name";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(203, 436);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(124, 27);
            this.btnReturnBook.TabIndex = 15;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(58, 436);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(124, 27);
            this.btnIssueBook.TabIndex = 16;
            this.btnIssueBook.Text = "Issue";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // dgvIssuedBooks
            // 
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(409, 362);
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.RowHeadersWidth = 62;
            this.dgvIssuedBooks.RowTemplate.Height = 28;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(513, 209);
            this.dgvIssuedBooks.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "ISSUE/RETURN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "ADD/DELETE";
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvIssuedBooks);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.txtIssueSrNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.ilbQuantity);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtBookSrNo);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.ilbSrNo);
            this.Controls.Add(this.ilbAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.ilbtxt);
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianForm";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ilbtxt;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label ilbAuthor;
        private System.Windows.Forms.Label ilbSrNo;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookSrNo;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label ilbQuantity;
        private System.Windows.Forms.TextBox txtIssueSrNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}