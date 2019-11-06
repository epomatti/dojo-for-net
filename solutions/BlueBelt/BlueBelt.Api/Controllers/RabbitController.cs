using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyNetQ;

namespace BlueBelt.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RabbitController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Publish("message");
                bus.Subscribe<String>("my_subscription_id", msg => Console.WriteLine(msg));
            }
        }
    }
}