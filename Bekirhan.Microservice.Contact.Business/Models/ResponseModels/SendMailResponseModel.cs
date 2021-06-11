using System;
using System.Collections.Generic;
using System.Text;

namespace Bekirhan.Microservice.Contact.Business.Models.ResponseModels
{
    public class SendMailResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
