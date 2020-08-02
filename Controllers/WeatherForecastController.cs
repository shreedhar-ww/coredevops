using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;  

namespace servicetwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/api/Weather/get")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 15).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary ="Shreedhar"+ Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("/api/Weather/servername")]
        public object Getservername()
        {
            
           List<string> host = new List<string>();
           string HostName = Dns.GetHostName();  
            Console.WriteLine("Host Name of machine =" + HostName);  
            IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);  
            Console.Write("IPv4 of Machine is ");  
            foreach (IPAddress ip4 in ipaddress.Where(ip => ip.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork))  
            {  
                host.Add(ip4.ToString());  
            }  
            
            foreach (IPAddress ip6 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6))  
            {   
                  host.Add(ip6.ToString());  
            } 
           return host;
        }
        [HttpGet]
        [Route("/api/Weather/servername")]
        public object Getservername2()
        {
            
           List<string> host = new List<string>();
           string HostName = Dns.GetHostName();  
            Console.WriteLine("Host Name of machine =" + HostName);  
            IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);  
            Console.Write("IPv4 of Machine is ");  
            foreach (IPAddress ip4 in ipaddress.Where(ip => ip.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork))  
            {  
                host.Add(ip4.ToString());  
            }  
            
            foreach (IPAddress ip6 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6))  
            {   
                  host.Add(ip6.ToString());  
            } 
           return host;
        }
    }
}
