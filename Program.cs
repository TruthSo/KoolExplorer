using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoolExplorer.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KoolExplorer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GovAPIController gov = new GovAPIController();
            //gov.EnrolmentMOEKindergartens().GetAwaiter().GetResult();
            //gov.NetEnrolmentRatio().GetAwaiter().GetResult();
            gov.ListingOfCentreService().GetAwaiter().GetResult();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
