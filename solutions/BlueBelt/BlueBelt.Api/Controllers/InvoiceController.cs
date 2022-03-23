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
      _bus.SendReceive.Send("invoices", invoice);
    }
  }
}