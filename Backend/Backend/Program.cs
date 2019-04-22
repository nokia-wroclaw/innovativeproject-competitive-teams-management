﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();

            var host = CreateWebHostBuilder(args).Build();
            
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception )
                {
                    
                }
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
