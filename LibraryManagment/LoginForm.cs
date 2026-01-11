using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Librarian");
            cmbRole.Items.Add("Member");

            cmbRole.SelectedIndex = 0; // Default selection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selectedRole = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                selectedRole == null)
            {
                MessageBox.Show("Please select a role and enter credentials.", "Input Error");
                return;
            }

            if (selectedRole == "Librarian")
            {
                if (username == "tayyab" && password == "uol123")
                {
                    LibrarianForm libForm = new LibrarianForm();
                    libForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Librarian Password!");
                }
            }
            else if (selectedRole == "Member")
            {
                if (username == "sidra" && password == "123456")
                {
                    MemberForm memForm = new MemberForm();
                    memForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Member Password!");
                }
            }
        }
    }
}

