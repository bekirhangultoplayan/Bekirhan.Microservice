using Bekirhan.Microservice.Contact.Business.Abstract;
using Bekirhan.Microservice.Contact.Business.Concrete; 
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bekirhan.Microservice.Contact.Business.ServiceConfiguration
{
    public class DependencyConfiguration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IEmailSender, EmailSender>();       
        }
    }
}