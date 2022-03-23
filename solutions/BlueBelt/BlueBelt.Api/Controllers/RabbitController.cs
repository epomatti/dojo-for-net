using Microsoft.AspNetCore.Mvc;
using EasyNetQ;
using Dojo;

namespace BlueBelt.Api.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class RabbitController : ControllerBase
  {
    IBus _bus;

    public RabbitController(IBus bus)
    {
      _bus = bus;
    }

    [HttpGet]
    public void Get([FromQuery] string text)
    {
      _bus.SendReceive.Send("dojo", new DojoMessage { Text = text });
    }
  }
}