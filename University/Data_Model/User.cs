using System;
using University;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace University.Data_Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string ID { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public DateTime LastSignIn { get; set; }
        public string Position { get; set; }
        public string UniversityID { get; set; }
        public string Email { get; set; }
        public List<Message> Messages { get; set; }
        public string Course { get; set; }


        public User(string[] userInfo)
        {
            if (userInfo.Length >= 15)
            {
                Username = userInfo[0];
                Password = userInfo[1];
                FullName = userInfo[2];
                PhoneNumber = userInfo[3];
                ID = userInfo[4];
                Age = userInfo[5];
                Address = userInfo[6];
                LastSignIn = DateTime.ParseExact(userInfo[7], "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                Position = userInfo[8];
                UniversityID = userInfo[9];
                Email = userInfo[10];
                Course = userInfo[11];
                Messages = new List<Message>();

            }
            else
            {     
                Username = "Unknown";
                Password = "Unknown";
                FullName = "Unknown";
                PhoneNumber = "Unknown";
                ID = "Unknown";
                Age = "0";
                Address = "Unknown";
                LastSignIn = DateTime.MinValue;
                Position = "Unknown";
                UniversityID = "Unknown";
                Email = "Unknown";
                Course = "Unknown";
                Messages = new List<Message>();

            }
        }
        public User(string id, string name, string phoneNumber, string email)
        {
            ID = id;
            FullName = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Messages = new List<Message>();
        }


    }
}
