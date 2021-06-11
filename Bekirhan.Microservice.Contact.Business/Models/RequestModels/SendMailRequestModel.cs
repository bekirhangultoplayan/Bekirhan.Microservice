using System;
using System.Collections.Generic;
using System.Text;

namespace Bekirhan.Microservice.Contact.Business.Models.RequestModels
{
    public class SendMailRequestModel
    {
        public EmailContentModel Content { get; set; }
        public EmailSenderModel Sender { get; set; }
    }
}
