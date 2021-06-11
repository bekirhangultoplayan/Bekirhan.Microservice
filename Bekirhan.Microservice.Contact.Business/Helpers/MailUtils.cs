using Bekirhan.Microservice.Contact.Business.Models.RequestModels;
using Bekirhan.Microservice.Contact.Business.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bekirhan.Microservice.Contact.Business.Helpers
{
    public class MailUtils
    {
        public static async Task<SendMailResponseModel> SendEmailAsync(SendMailRequestModel contentModel)
        {
            SendMailResponseModel result = new SendMailResponseModel();
            result.Status = false;
            try
            {
                MailMessage mail = new MailMessage() { From = new MailAddress(contentModel.Sender.FromAddress, contentModel.Sender.FromName) };
                if (contentModel.Content.Emails != null && contentModel.Content.Emails.Count > 0)
                {
                    foreach (var toEmail in contentModel.Content.Emails)
                    {
                        mail.To.Add(new MailAddress(toEmail));
                    }
                }
                else
                {
                    foreach (var toEmail in contentModel.Sender.ToEmail)
                    {
                        mail.To.Add(new MailAddress(toEmail));
                    }
                }
                if (contentModel.Sender.CcEmail != null && contentModel.Sender.CcEmail.Count > 0)
                {
                    foreach (var email in contentModel.Sender.CcEmail)
                    {
                        mail.CC.Add(new MailAddress(email));
                    }
                }
                if (contentModel.Sender.BccEmail != null && contentModel.Sender.BccEmail.Count > 0)
                {
                    foreach (var email in contentModel.Sender.BccEmail)
                    {
                        mail.Bcc.Add(new MailAddress(email));
                    }
                }
                if (contentModel.Content.Attachments != null && contentModel.Content.Attachments.Count > 0)
                {
                    foreach (var item in contentModel.Content.Attachments)
                    {
                        mail.Attachments.Add(item);
                    }
                }
                mail.Subject = contentModel.Content.Subject;
                mail.Body = contentModel.Content.Message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                using (SmtpClient smtp = new SmtpClient(contentModel.Sender.ServerAddress, contentModel.Sender.ServerPort))
                {
                    smtp.Credentials = new NetworkCredential(contentModel.Sender.Username, contentModel.Sender.Password);
                    smtp.EnableSsl = contentModel.Sender.ServerUseSsl;

                    await smtp.SendMailAsync(mail);
                    result.Status = true; 
                    result.Message = "Success";
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message; 
            }
            return result;

        }
    }
}
