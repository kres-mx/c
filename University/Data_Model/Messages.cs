using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Data_Model;

namespace University.Data_Model
{
    public class Message
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsFavorite { get; set; }

        public Message(string sender, string recipient, string content, DateTime timestamp)
        {
            Sender = sender;
            Recipient = recipient;
            Content = content;
            Timestamp = timestamp;
            IsFavorite = false;
        }
    }
}
