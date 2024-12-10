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

namespace University
{

    public partial class FormMessages : Form
    {
        private static List<University.Data_Model.Message> allMessages = new List<University.Data_Model.Message>();
        private List<University.Data_Model.Message> messages;
        private List<University.Data_Model.Message> favoriteMessages = new List<University.Data_Model.Message>();
        private List<User> users;
        private string signedInUserName;
        private FrmMain frmMain;
       
        public FormMessages(string signedInUserName, string[] lines)
        {
            InitializeComponent();
            this.signedInUserName = signedInUserName;
            users = new List<User>();
            DarkModeManager.StoreOriginalColors(this);

            InitializeData(lines);

            listViewMsg.View = View.Details;
            listViewMsg.Columns.Add("Sender");
            listViewMsg.Columns.Add("Recipient");
            listViewMsg.Columns.Add("Timestamp");
            listViewMsg.Columns.Add("Content");
            listViewMsg.Columns.Add("Favorite");
            listViewMsg.FullRowSelect = true;

            PopulateMessagesListView();
        }
        private void InitializeData(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] userInfo = line.Split(',');

                if (userInfo.Length >= 11)
                {
                    string username = userInfo[0];

                    User user = new User(userInfo)
                    {
                        Username = username,
                        Password = userInfo[1],
                        FullName = userInfo[2],
                        PhoneNumber = userInfo[3],
                        ID = userInfo[4],
                        Age = userInfo[5],
                        Address = userInfo[6],
                        LastSignIn = DateTime.ParseExact(userInfo[7], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        Position = userInfo[8],
                        UniversityID = userInfo[9],
                        Email = userInfo[10],
                    };

                    users.Add(user);
                }
                else
                {
                    Console.WriteLine("Invalid user information: " + line);
                }
            }
        }

        public FormMessages(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }
        private void SortMessagesListView(List<University.Data_Model.Message> sortedMessages)
        {
            listViewMsg.Items.Clear();

            foreach (var message in sortedMessages)
            {
                string[] messageDetails = { message.Sender, message.Recipient, message.Timestamp.ToString(), message.Content, message.IsFavorite ? "Yes" : "No" };
                listViewMsg.Items.Add(new ListViewItem(messageDetails));
            }
        }

        private void FormMessages_Load(object sender, EventArgs e)
        {

        }
        private void btnSortBySenderPosition_Click_1(object sender, EventArgs e)
        {
            if (allMessages != null && allMessages.Count > 0)
            {
                var sortedMessages = allMessages.OrderBy(m =>
                {
                    var senderUser = users.FirstOrDefault(u => u.Username == m.Sender);
                    return senderUser != null ? GetPositionPriority(senderUser.Position) : int.MaxValue;
                }).ToList();
                SortMessagesListView(sortedMessages);
            }
            else
            {
                MessageBox.Show("No messages to sort!");
            }
        }
        private int GetPositionPriority(string position)
        {
            switch (position)
            {
                case "Department head":
                    return 4;
                case "Lecturer":
                    return 3;
                case "Practitioner":
                    return 2;
                case "Student":
                    return 1;
                default:
                    return int.MaxValue;
            }
        }
        private void btnSortByFavorite_Click(object sender, EventArgs e)
        {
            listViewMsg.Items.Clear();

            if (favoriteMessages.Count > 0)
            {
                foreach (var message in favoriteMessages)
                {
                    string[] messageDetails = { message.Sender, message.Recipient, message.Timestamp.ToString(), message.Content, message.IsFavorite ? "Yes" : "No" };
                    listViewMsg.Items.Add(new ListViewItem(messageDetails));
                }
            }
            else
            {
                MessageBox.Show("No favorite messages found!");
            }
        }

        private void btnSortByDate_Click_1(object sender, EventArgs e)
        {
            if (allMessages != null && allMessages.Count > 0)
            {
                var sortedMessages = allMessages.OrderBy(m => m.Timestamp).ToList();
                SortMessagesListView(sortedMessages);
            }
            else
            {
                MessageBox.Show("No messages to sort!");
            }
        }
        private void btnSendMessage_Click_1(object sender, EventArgs e)
        {
            string senderUsername = signedInUserName;
            string recipientUsername = textBoxRecipient.Text;
            string content = richTextBoxMessage.Text;
            DateTime timestamp = DateTime.Now;

            User senderUser = users.FirstOrDefault(u => u.Username == senderUsername);
            User recipientUser = users.FirstOrDefault(u => u.Username == recipientUsername);

            if (senderUser != null && recipientUser != null)
            {
                University.Data_Model.Message message = new University.Data_Model.Message(senderUsername, recipientUsername, content, timestamp);
                allMessages.Add(message);

                if (recipientUsername == signedInUserName)
                {
                    listViewMsg.Items.Add(new ListViewItem(new string[] { message.Sender, message.Recipient, message.Timestamp.ToString(), message.Content, message.IsFavorite ? "Yes" : "No" }));
                }

                MessageBox.Show("Your message has been sent successfully!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateMessagesListView();
            }
            else
            {
                MessageBox.Show("Sender or recipient not found. Please check the usernames.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void PopulateMessagesListView()
        {
            listViewMsg.Items.Clear();

            foreach (var message in allMessages)
            {
                if (message.Recipient == signedInUserName || message.Sender == signedInUserName)
                {
                    listViewMsg.Items.Add(new ListViewItem(new string[] { message.Sender, message.Recipient, message.Timestamp.ToString(), message.Content, message.IsFavorite ? "Yes" : "No" }));
                }
            }
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (listViewMsg.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewMsg.SelectedItems[0];
                University.Data_Model.Message selectedMessage = allMessages.FirstOrDefault(m =>
                    m.Sender == selectedItem.SubItems[0].Text &&
                    m.Recipient == selectedItem.SubItems[1].Text &&
                    m.Timestamp.ToString() == selectedItem.SubItems[2].Text &&
                    m.Content == selectedItem.SubItems[3].Text);

                if (selectedMessage != null)
                {
                    selectedMessage.IsFavorite = !selectedMessage.IsFavorite;
                    selectedItem.SubItems[4].Text = selectedMessage.IsFavorite ? "Yes" : "No";

                    if (selectedMessage.IsFavorite)
                    {
                        favoriteMessages.Add(selectedMessage);
                    }
                    else
                    {
                        favoriteMessages.Remove(selectedMessage);
                    }

                    MessageBox.Show("You've added this message to your favorites!", "Message Favorited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected message not found!. Please try again.", "Message Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

