using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bekirhan.Microservice.Contact.API.Models
{
    public class ResponseWrapper<TResponseModel>
    {
        public bool IsResponseSuccessfull { get; set; }
        public TResponseModel Response { get; set; }
    }
}
