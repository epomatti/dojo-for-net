using System;
using Dojo;
using EasyNetQ;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlueBelt.Api
{
  public class Startup
  {

    IBus bus;

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      CreateBus();
      services.AddSingleton(bus);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      ListenToMessages();
      lifetime.ApplicationStopping.Register(OnShutdown);
    }

    private void CreateBus()
    {
      bus = RabbitHutch.CreateBus("host=localhost");
    }
    private void ListenToMessages()
    {
      bus.SendReceive.Receive<DojoMessage>("dojo", message => Console.WriteLine("MyMessage: {0}", message.Text));
      Console.WriteLine("LISTENING TO MESSAGES");
    }
    private void OnShutdown()
    {
      Console.WriteLine("Disposing Bus");
      bus.Dispose();
      Console.WriteLine("Bus disposed");
    }
  }
}
