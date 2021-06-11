using Bekirhan.Microservice.Contact.Business.Abstract;
using Bekirhan.Microservice.Contact.Business.Helpers;
using Bekirhan.Microservice.Contact.Business.Models;
using Bekirhan.Microservice.Contact.Business.Models.RequestModels;
using Bekirhan.Microservice.Contact.Business.Models.ResponseModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks; 

namespace Bekirhan.Microservice.Contact.Business.Concrete
{
    public class EmailSender : IEmailSender
    {

        public async Task<SendMailResponseModel> SendEmailAsync(SendMailRequestModel contentModel)
        {
            var result = await MailUtils.SendEmailAsync(contentModel);
            return result;
        }

       
    }
}
