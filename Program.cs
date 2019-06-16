using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotnet_automated
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) {
            
            // tries to get port from environment for cloud run
            string port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
            string url = String.Concat("http://0.0.0.0:", port);

            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().UseUrls(url);
        }
    }
}
