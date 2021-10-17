using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using KissKartan.API.Models;
using System.IO;

namespace KissKartan
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ToiletService serv = new ToiletService();
            RatingService servr = new RatingService();         
            
            var t = serv.Get(2);

            List<Rating> ratings = new List<Rating>()
        {
            new Rating{
                Id = 1,
                 Stars = 4,
                Toilet = t
            },
            new Rating{
                Id = 2,
                 Stars = 3,
                Toilet =  serv.Get(1)
            },
                new Rating{
                    Id = 3,
                 Stars = 2,
                Toilet =  serv.Get(3)
            },

        };

            //SKAPA EN TYPESERVICE MED GET & GETALL

           
            foreach (var item in ratings)
            {
                servr.Add(item);
            }
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
