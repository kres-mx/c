using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace University
{
    public partial class signUpForm : Form
    {
        private string role = "";
        private string Course = "";

        public signUpForm()
        {
            InitializeComponent();
        }
        private bool UserExists(string id)
        {
            string[] users = File.ReadAllLines("Users.txt");

            foreach (string user in users)
            {
                string[] userFields = user.Split(',');

                if (userFields.Length > 4 && userFields[4] == id)
                {
                    return true; 
                }
            }

            return false; 
        }
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string fullName = textBoxFullName.Text;
            string phoneNum = textBoxPhoneNum.Text;
            string id = textBoxID.Text;
            string age = textBoxAge.Text;
            string address = textBoxAddress.Text;
            

            if (UserExists(id))
            {
                MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userName != null && password != null && fullName != null && phoneNum != null && id != null && age != null && address != null && role != null && Course!= null)
            {
                string universityID = GenerateUniversityID().ToString();
                string userRecord = $"{userName},{password},{fullName},{phoneNum},{id},{age},{address},{DateTime.Now},{role},{universityID},{email},{Course}\n";
                File.AppendAllText("Users.txt", userRecord);

                MessageBox.Show("Your account has been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMain f1 = new FrmMain(userName, null); 
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }
        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            role = "Student";
        }

        private void radioButtonDepartmentHead_CheckedChanged(object sender, EventArgs e)
        {
            role = "Department Head";
        }

        private void radioButtonLectturer_CheckedChanged(object sender, EventArgs e)
        {
            role = "Lecturer";
        }

        private void radioButtonPractitioner_CheckedChanged(object sender, EventArgs e)
        {
            role = "Practitioner";
        }

        private void radioButtonJava_CheckedChanged(object sender, EventArgs e)
        {
            Course = "Java";
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            Course = "C#";
        }

        private void radioButtonPython_CheckedChanged(object sender, EventArgs e)
        {
            Course = "Python";
        }

        private void radioButtonJS_CheckedChanged(object sender, EventArgs e)
        {
            Course = "JavaScript";
        }
        public static int GenerateUniversityID()
        {
            string[] lines = File.ReadAllLines("Users.txt");
            string[] universityIDs = lines
                .Where(line => line.Split(',').Length >= 10) 
                .Select(line => line.Split(',')[9]) 
                .ToArray();

            Random random = new Random();
            int universityID;

            do
            {
                universityID = random.Next(100, 999999);
            }
            while (universityIDs.Contains(universityID.ToString())); // Check if the generated ID already exists

            return universityID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form signInForm = new signInForm();
            this.Hide();
            signInForm.ShowDialog();
            this.Close();
        }
        private void textBoxuserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void signUpForm_Load(object sender, EventArgs e)
        {

        }
        private void labeluserName_Click(object sender, EventArgs e)
        {

        }
        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelAs_Click(object sender, EventArgs e)
        {

        }
        private void panelCourse_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
        