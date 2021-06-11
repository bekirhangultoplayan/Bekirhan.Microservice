using Bekirhan.Microservice.Contact.API.Models;
using Bekirhan.Microservice.Contact.Business.Abstract;
using Bekirhan.Microservice.Contact.Business.Models.RequestModels;
using Bekirhan.Microservice.Contact.Business.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bekirhan.Microservice.Contact.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MailController : Controller
    {
        private readonly IEmailSender _emailSender;
        public MailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpPost]
        public async Task<ResponseWrapper<SendMailResponseModel>> Send([FromBody] SendMailRequestModel model)
        {
            var result = await _emailSender.SendEmailAsync(model);
            return new ResponseWrapper<SendMailResponseModel>
            {
                IsResponseSuccessfull = true,
                Response = result,
            };
        }
         


        public IActionResult Index()
        {
            return View();
        }
    }
}
