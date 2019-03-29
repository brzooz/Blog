using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IEnumerable<IMessageService> _messageServices;

        public NotificationsController(IEnumerable<IMessageService> messageServices)
        {
            _messageServices = messageServices;
        }

        [HttpGet]
        public IEnumerable<string> GetMessageServiceTypes()
        {
            return _messageServices.Select(x => x.GetType().ToString());
        }
    }
}
