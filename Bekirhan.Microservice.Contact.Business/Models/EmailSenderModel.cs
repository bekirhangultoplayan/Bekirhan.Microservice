using System;
using System.Collections.Generic;
using System.Text;

namespace Bekirhan.Microservice.Contact.Business.Models
{
    public class EmailSenderModel
    {
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public List<string> ToEmail { get; set; }
        public List<string> CcEmail { get; set; }
        public List<string> BccEmail { get; set; }
        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }
        public bool ServerUseSsl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
