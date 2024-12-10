using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace University
{
    public partial class FormOptions : Form
    {

        private FrmMain frmMain;
        public FormOptions()
        {
            InitializeComponent();
            DarkModeManager.StoreOriginalColors(this);

        }

        private void FormOptions_Load(object sender, EventArgs e)
        {

        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //signInForm signInFormInstance = new signInForm();
            //signInFormInstance.Show();
            //this.Close();
            signInForm newSignInForm = new signInForm();
            this.Hide();
            MessageBox.Show("You have been successfully signed out!", "Signed Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            newSignInForm.ShowDialog();
            this.Close();
        }
        public FormOptions(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            DarkModeManager.IsDarkMode = !DarkModeManager.IsDarkMode;

            DarkModeManager.ApplyDarkMode(this);

            ApplyDarkModeToAllForms();
        }
        private void ApplyDarkModeToAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    DarkModeManager.ApplyDarkMode(form);

                    form.BackColor = DarkModeManager.IsDarkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
