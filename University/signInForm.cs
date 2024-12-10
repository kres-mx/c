using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace University
{
    public partial class signInForm : Form
    {
        private string fullName;
        public string SignedInUserName { get; set; }


        public signInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void btnSignin_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Users.txt");

            string userName = UserName.Text;
            string inputPassword = password.Text;

            bool userFound = false;
            string fullName = string.Empty;
            string lastSignInTime = string.Empty;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] userFields = line.Split(',');

                if (userFields.Length >= 9 && userFields[0] == userName && userFields[1] == inputPassword)
                {
                    userFound = true;
                    fullName = userFields[2];
                    lastSignInTime = userFields[7];

                    DateTime currentDateTime = DateTime.Now;
                    userFields[7] = currentDateTime.ToString();

                    lines[i] = string.Join(",", userFields);

                    break;
                }
            }

            if (userFound)
            {
                File.WriteAllLines("Users.txt", lines);

                FrmMain f1 = new FrmMain(userName, lines); 
                this.Hide();
                MessageBox.Show($"Welcome back, {fullName}! Your last sign-in was at {lastSignInTime}.", "Welcome Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The email/password is incorrect. Please try again.", "Invalid Input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form signUpForm = new signUpForm();
            this.Hide();
            signUpForm.ShowDialog();
            this.Close();
        }
        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
