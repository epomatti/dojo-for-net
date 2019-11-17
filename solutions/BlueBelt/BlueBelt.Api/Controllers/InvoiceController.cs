using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyNetQ;
using Dojo;

namespace BlueBelt.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        IBus _bus;

        public InvoiceController(IBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public void Post([FromQuery] Invoice invoice)
        {
            _bus.Send("invoices", invoice);
        }
    }
}