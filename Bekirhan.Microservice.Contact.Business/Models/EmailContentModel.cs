using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Bekirhan.Microservice.Contact.Business.Models
{
    public class EmailContentModel
    {
        public List<string> Emails { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
     
}
