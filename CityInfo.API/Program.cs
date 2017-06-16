using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace CityInfo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder() //builds the host using various components - can be changed dependent on requirements/environment
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

           host.Run();
        }
    }
}
