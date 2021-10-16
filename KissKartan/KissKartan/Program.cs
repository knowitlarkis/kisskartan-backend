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
            TypePropertyService servt = new TypePropertyService();

            var types = servt.GetAll();
             TypeProperty ett = types[1];
             TypeProperty two = types[2];

            List<Toilet> toilets = new List<Toilet>()
        {
                //LÄGG TILL LISTA AV TYPEPROPERTIES
            new Toilet{
                Location = "59.86029306150929, 17.638249261540285",
                Description = "Offentlig toalett i St. Per-gallerian, en trappa ner",
                IsFree = true,
                LastCleaned = DateTime.Today,
                Types = new List<TypeProperty> { ett, two }
            },
            new Toilet
            { Location = "59.85821946252539, 17.646533452978318",
                Description = "Offentlig toalett i stationshuset, bottenplan, kortbetalning",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-14),
                Types = new List<TypeProperty> { ett, two }
            },
            new Toilet
                {Location = "59.85361904298998, 17.61361074332028",
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                Types = new List<TypeProperty> { ett, two }
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
            
            //SKAPA EN TYPESERVICE MED GET & GETALL

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
