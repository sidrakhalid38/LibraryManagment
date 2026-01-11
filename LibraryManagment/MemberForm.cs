using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // 1. REQUIRED for file handling


namespace LibraryManagment
{
    public partial class MemberForm : Form
    {
        // Class-level variables
        DataTable memberTable = new DataTable();
        string filePath;

        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            // --- Ensure Data folder exists ---
            string dataFolder = Path.Combine(Application.StartupPath, "Data");
            if (!Directory.Exists(dataFolder))
                Directory.CreateDirectory(dataFolder);

            filePath = Path.Combine(dataFolder, "books.txt");

            // --- Setup DataTable columns ---
            if (memberTable.Columns.Count == 0)
            {
                memberTable.Columns.Add("SrNo");
                memberTable.Columns.Add("Title");
                memberTable.Columns.Add("Author");
                memberTable.Columns.Add("Quantity");
            }
            else
            {
                memberTable.Clear(); // Clear rows, keep columns
            }

            // --- Load books from file ---
            if (File.Exists(filePath))
            {
                string[] allLines = File.ReadAllLines(filePath);
                foreach (string line in allLines)
                {
                    string[] data = line.Split(',');
                    if (data.Length == 4)
                        memberTable.Rows.Add(data[0], data[1], data[2], data[3]);
                }
            }
            else
            {
                MessageBox.Show("No book data found. Please ask Librarian to add books.");
            }

            // --- Bind to DataGridView ---
            dgvMemberBooks.DataSource = memberTable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Filter books by Title
            DataView dv = memberTable.DefaultView;
            dv.RowFilter = string.Format("Title LIKE '%{0}%'", txtSearch.Text);
            dgvMemberBooks.DataSource = dv.ToTable();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
