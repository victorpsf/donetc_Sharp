using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Estudo
{
    public class Program
    {
        public static int Main(string[] args)
        {
            IHost Builder = null;

            
            // start configuration and build project
            try {
                Builder = CreateHostBuilder(args).Build();
            } catch (Exception error) {
                return 1;
            }

            // start custom services
            try {

            } catch (Exception error) {
                return 1;
            }

            // start server
            try {
                Builder.Run();
                return 0;
            } catch (Exception error) {
                return 1;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
