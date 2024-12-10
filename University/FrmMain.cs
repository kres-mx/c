using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Data_Model;
using static System.Windows.Forms.LinkLabel;

namespace University
{
    public partial class FrmMain : Form
    {
        private List<University.Data_Model.Message> messages;
        private List<User> users;
        private string filePath = "Users.txt";
        private string signedInUserName;
        private signInForm signInFormInstance;
        private string[] lines;

        public FrmMain(string signedInUserName, string[] lines)
        {
            InitializeComponent();
            this.lines = lines;
            this.signedInUserName = signedInUserName;
            users = new List<User>();
            DarkModeManager.StoreOriginalColors(this);

            if (lines != null && lines.Length > 0)
            {
                User signedInUser = new User(lines)
                {
                    Username = signedInUserName,
                    Messages = new List<University.Data_Model.Message>()
                };
                users.Add(signedInUser);

                messages = new List<University.Data_Model.Message>();

                foreach (string line in lines)
                {
                    string[] userFields = line.Split(',');
                    if (userFields.Length >= 10)
                    {
                        string universityID = userFields[9];
                        string userName = userFields[0];

                        if (userName != signedInUserName)
                        {
                            User user = new User(userFields)
                            {
                                Username = userName,
                                Password = userFields[1],
                                FullName = userFields[2],
                                PhoneNumber = userFields[3],
                                ID = userFields[4],
                                Age = userFields[5],
                                Address = userFields[6],
                                LastSignIn = DateTime.ParseExact(userFields[7], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                                Position = userFields[8],
                                Email = userFields[10],
                                Course = userFields[11],
                                Messages = new List<Data_Model.Message>()

                            };

                            users.Add(user);

                            foreach (University.Data_Model.Message message in user.Messages)
                            {
                                messages.Add(message);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid user information: " + line);
                    }
                }
            }

            listViewMsg.View = View.Details;
            listViewMsg.Columns.Add("Sender");
            listViewMsg.Columns.Add("Recipient");
            listViewMsg.Columns.Add("Timestamp");
            listViewMsg.Columns.Add("Content");

            PopulateMessagesListView();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Users.txt");

            string userName = ""; 

            foreach (string line in lines)
            {
                string[] userFields = line.Split(',');

                if (userFields.Length >= 8 && userFields[0] == signedInUserName) 
                {
                    userName = userFields[0];

                    User user = new User(userFields)
                    {
                        Username = userFields[0],
                        Password = userFields[1],
                        FullName = userFields[2],
                        PhoneNumber = userFields[3],
                        ID = userFields[4],
                        Age = userFields[5],
                        Address = userFields[6],
                        LastSignIn = DateTime.ParseExact(userFields[7], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        Position = userFields[8],
                        UniversityID = userFields[9],
                        Email = userFields[10],
                        Course = userFields[11] 
                    };

                    FormPersonalInfo formPersonalInfo = new FormPersonalInfo(user);
                    formPersonalInfo.ShowDialog();
                    break;
                }
            }
        }
        private void btnMessages_Click(object sender, EventArgs e)
        {
            FormMessages formMessages = new FormMessages(signedInUserName, lines);
            formMessages.Show();
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            FormOptions formOptions = new FormOptions();
            formOptions.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("users.txt");
            FormSearch formSearch = new FormSearch(lines);
            formSearch.ShowDialog();
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string senderUsername = GetSignedInUser(); 
            string recipientUsername = textBoxRecipient.Text; 
            string content = richTextBoxMessage.Text; 
            DateTime timestamp = DateTime.Now; 

            User senderUser = users.FirstOrDefault(u => u.Username == senderUsername);
            User recipientUser = users.FirstOrDefault(u => u.Username == recipientUsername);

            if (senderUser != null && recipientUser != null)
            {
                University.Data_Model.Message message = new University.Data_Model.Message(senderUsername, recipientUsername, content, timestamp);
                senderUser.Messages.Add(message);
                recipientUser.Messages.Add(message); 
                messages.Add(message);

                ListViewItem item = new ListViewItem(message.Sender);
                item.SubItems.Add(message.Recipient);
                item.SubItems.Add(message.Timestamp.ToString());
                item.SubItems.Add(message.Content);
                listViewMsg.Items.Add(item);

                MessageBox.Show("Message sent successfully!");
            }
            else
            {
                MessageBox.Show("Sender or recipient not found. Please check the usernames.");
            }
        }
        private string GetSignedInUser()
        {
            return signedInUserName;
        }
        private void PopulateMessagesListView()
        {
            listViewMsg.Items.Clear();
            var sortedMessages = messages.OrderBy(m => m.Timestamp).ToList();

            foreach (var message in sortedMessages)
            {
                ListViewItem item = new ListViewItem(message.Sender);
                item.SubItems.Add(message.Recipient);
                item.SubItems.Add(message.Timestamp.ToString());
                item.SubItems.Add(message.Content);

                listViewMsg.Items.Add(item);
            }
        }

        
    }
}
