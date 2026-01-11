using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagment
{
    public partial class LibrarianForm : Form
    {
        DataTable bookTable = new DataTable();
        DataTable issuedTable = new DataTable();

        string booksFilePath;
        string issuedFilePath;

        public LibrarianForm()
        {
            InitializeComponent();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            // ===== DATA FOLDER =====
            string dataFolder = Path.Combine(Application.StartupPath, "Data");
            if (!Directory.Exists(dataFolder))
                Directory.CreateDirectory(dataFolder);

            booksFilePath = Path.Combine(dataFolder, "books.txt");
            issuedFilePath = Path.Combine(dataFolder, "issued.txt");

            // ===== BOOK TABLE =====
            bookTable.Columns.Clear();
            bookTable.Columns.Add("SrNo");
            bookTable.Columns.Add("Title");
            bookTable.Columns.Add("Author");
            bookTable.Columns.Add("Quantity");

            if (File.Exists(booksFilePath))
            {
                foreach (string line in File.ReadAllLines(booksFilePath))
                {
                    string[] d = line.Split(',');
                    if (d.Length == 4)
                        bookTable.Rows.Add(d[0], d[1], d[2], d[3]);
                }
            }

            dgvBooks.DataSource = bookTable;

            // ===== ISSUED TABLE =====
            issuedTable.Columns.Clear();
            issuedTable.Columns.Add("MemberName");
            issuedTable.Columns.Add("SrNo");
            issuedTable.Columns.Add("Title");
            issuedTable.Columns.Add("Author");
            issuedTable.Columns.Add("IssueDate");

            if (File.Exists(issuedFilePath))
            {
                foreach (string line in File.ReadAllLines(issuedFilePath))
                {
                    string[] d = line.Split(',');
                    if (d.Length == 5)
                        issuedTable.Rows.Add(d[0], d[1], d[2], d[3], d[4]);
                }
            }

            dgvIssuedBooks.DataSource = issuedTable;
        }

        // ===== SAVE BOOKS =====
        private void SaveBooksToFile()
        {
            List<string> lines = new List<string>();
            foreach (DataRow r in bookTable.Rows)
                lines.Add($"{r["SrNo"]},{r["Title"]},{r["Author"]},{r["Quantity"]}");

            File.WriteAllLines(booksFilePath, lines);
        }

        // ===== SAVE ISSUED =====
        private void SaveIssuedToFile()
        {
            List<string> lines = new List<string>();
            foreach (DataRow r in issuedTable.Rows)
                lines.Add($"{r["MemberName"]},{r["SrNo"]},{r["Title"]},{r["Author"]},{r["IssueDate"]}");

            File.WriteAllLines(issuedFilePath, lines);
        }

        // ===== ADD BOOK =====
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bookTable.Rows.Add(
                txtBookSrNo.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtQuantity.Text
            );

            SaveBooksToFile();
            MessageBox.Show("Book Added");
        }

        // ===== DELETE BOOK =====
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                bookTable.Rows.RemoveAt(dgvBooks.SelectedRows[0].Index);
                SaveBooksToFile();
            }
        }

        // ===== ISSUE BOOK =====
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in bookTable.Rows)
            {
                if (row["SrNo"].ToString() == txtIssueSrNo.Text &&
                    int.Parse(row["Quantity"].ToString()) > 0)
                {
                    row["Quantity"] = int.Parse(row["Quantity"].ToString()) - 1;

                    issuedTable.Rows.Add(
                        txtMemberName.Text,
                        row["SrNo"],
                        row["Title"],
                        row["Author"],
                        DateTime.Now.ToString("dd-MMM-yyyy")
                    );

                    SaveBooksToFile();
                    SaveIssuedToFile();

                    MessageBox.Show("Book Issued");
                    return;
                }
            }

            MessageBox.Show("Book not available");
        }

        // ===== RETURN BOOK =====
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            DataRow issuedRow = null;

            foreach (DataRow r in issuedTable.Rows)
            {
                if (r["SrNo"].ToString() == txtIssueSrNo.Text &&
                    r["MemberName"].ToString() == txtMemberName.Text)
                {
                    issuedRow = r;
                    break;
                }
            }

            if (issuedRow == null)
            {
                MessageBox.Show("Record not found");
                return;
            }

            issuedTable.Rows.Remove(issuedRow);

            foreach (DataRow r in bookTable.Rows)
            {
                if (r["SrNo"].ToString() == txtIssueSrNo.Text)
                {
                    r["Quantity"] = int.Parse(r["Quantity"].ToString()) + 1;
                    break;
                }
            }

            SaveBooksToFile();
            SaveIssuedToFile();

            MessageBox.Show("Book Returned");
        }
    }
}







