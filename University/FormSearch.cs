using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Data_Model;
using static System.Windows.Forms.LinkLabel;

namespace University
{
    public partial class FormSearch : Form
    {
        private List<User> users;
        private FrmMain frmMain;

        public FormSearch(string[] lines)
        {
            InitializeComponent();
            users = new List<User>();
            DarkModeManager.StoreOriginalColors(this);


            foreach (string line in lines)
            {
                string[] userInfo = line.Split(',');

                if (userInfo.Length >= 11) 
                {
                    string universityID = userInfo[9];

                    User user = new User(userInfo)
                    {
                        Username = userInfo[0],
                        Password = userInfo[1],
                        FullName = userInfo[2],
                        PhoneNumber = userInfo[3],
                        ID = userInfo[4],
                        Age = userInfo[5],
                        Address = userInfo[6],
                        LastSignIn = DateTime.ParseExact(userInfo[7], "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                        Position = userInfo[8],
                        UniversityID = universityID,
                        Email = userInfo[10] 
                    };

                    users.Add(user);
                }
                else
                {
                    Console.WriteLine("Invalid user information: " + line);
                }
            }
        }

        private void DisplaySearchResults(List<User> searchResults)
        {
            foreach (var user in searchResults)
            {
                richTextBoxUsers.AppendText("Name: " + user.FullName + Environment.NewLine);
                richTextBoxUsers.AppendText("E-mail: " + user.Email + Environment.NewLine);
                richTextBoxUsers.AppendText("University ID: " + user.UniversityID + Environment.NewLine);
                richTextBoxUsers.AppendText("Phone number: " + user.PhoneNumber + Environment.NewLine);
                richTextBoxUsers.AppendText("Position: " + user.Position + Environment.NewLine);
                richTextBoxUsers.AppendText(Environment.NewLine);
            }
        }
        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            {
                string searchName = textBoxSearchName.Text.Trim();
                string searchID = textBoxSearchID.Text.Trim();

                richTextBoxUsers.Clear();

                List<User> searchResults = new List<User>();

                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    List<User> nameResults = users.Where(u => u.FullName.Contains(searchName)).ToList();
                    searchResults.AddRange(nameResults);
                }

                if (!string.IsNullOrWhiteSpace(searchID))
                {
                    List<User> idResults = users.Where(u => u.UniversityID == searchID).ToList();
                    searchResults.AddRange(idResults);
                }

                searchResults = searchResults.Distinct().ToList();

                DisplaySearchResults(searchResults);
            }
        }
        private void buttonSendMSG_Click(object sender, EventArgs e)
        {
            string signedInUserName = "exampleUserName";
            string[] lines = { /* Array of message lines */ };

            FormMessages formMessages = new FormMessages(signedInUserName, lines);

            formMessages.Show();
            this.Close();
        }
        public FormSearch(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

