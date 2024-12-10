using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using University.Data_Model;

namespace University
{
    public partial class FormPersonalInfo : Form
    {
        private string signedInUserName;
        private User signedInUser;
        private string[] lines;
        private FrmMain frmMain;
        private User user;


        public FormPersonalInfo(User user)
        {
            InitializeComponent();
            this.user = user;
            DarkModeManager.StoreOriginalColors(this);
            textBoxUserName.Text = user.Username;
            textBoxUserName.ReadOnly = true;

            textBoxEmail.Text = user.Email;
            textBoxEmail.ReadOnly = true;

            textBoxPass.Text = user.Password;
            textBoxPass.ReadOnly = true;

            textBoxFullName.Text = user.FullName;
            textBoxFullName.ReadOnly = true;

            textBoxPhone.Text = user.PhoneNumber;
            textBoxPhone.ReadOnly = true;

            textBoxID.Text = user.ID;
            textBoxID.ReadOnly = true;

            textBoxAge.Text = user.Age;
            textBoxAge.ReadOnly = true;

            textBoxAddress.Text = user.Address;
            textBoxAddress.ReadOnly = true;

            textBoxPostion.Text = user.Position;
            textBoxPostion.ReadOnly = true;

            textBoxLast.Text = user.LastSignIn.ToString("dd/MM/yyyy HH:mm:ss");
            textBoxLast.ReadOnly = true;

            textBoxUniID.Text = user.UniversityID;
            textBoxUniID.ReadOnly = true;

            textBoxCourses.Text = user.Course;
            textBoxCourses.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserCredentialsFromFile("users.txt");
        }
        private void LoadUserCredentialsFromFile(string filePath)
        {
            lines = File.ReadAllLines(filePath);
        }
        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
        public FormPersonalInfo(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }
        private void personalInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCourses_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPostion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
