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

namespace KissKartan
{
    public class Program
    {
 
        public static void Main(string[] args)
        {
            ToiletService serv = new ToiletService();
            RatingService servr = new RatingService();
            List<Toilet> toilets = new List<Toilet>()
        {
            new Toilet{
                Location = "59.86029306150929, 17.638249261540285",
                Description = "Offentlig toalett i St. Per-gallerian, en trappa ner",
                IsFree = true,
                LastCleaned = DateTime.Today,
                //Types = { free, TypeProperty.Accessible}
            },
            new Toilet
            { Location = "59.85821946252539, 17.646533452978318",
                Description = "Offentlig toalett i stationshuset, bottenplan, kortbetalning",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-14)
            },
            new Toilet
                {Location = "59.85361904298998, 17.61361074332028",
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-3)
            }


        };

            List<Rating> ratings = new List<Rating>()
        {
            new Rating{
                 Stars = 4,
                Toilet = serv.Get(2)
            },
            new Rating{
                 Stars = 3,
                Toilet = serv.Get(2)
            },
                new Rating{
                 Stars = 2,
                Toilet = serv.Get(2)
            },


        };

            foreach (var item in toilets)
            {
                serv.Add(item);
            }
            foreach (var item in ratings)
            {
                servr.Add(item);
            }
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
