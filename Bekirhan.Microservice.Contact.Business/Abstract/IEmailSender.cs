using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using Bekirhan.Microservice.Contact.Business.Models;
using Bekirhan.Microservice.Contact.Business.Models.RequestModels;
using Bekirhan.Microservice.Contact.Business.Models.ResponseModels;

namespace Bekirhan.Microservice.Contact.Business.Abstract
{
    public interface IEmailSender
    {        
        Task<SendMailResponseModel> SendEmailAsync(SendMailRequestModel contentModel);
    }
}
