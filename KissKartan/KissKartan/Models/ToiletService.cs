using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissKartan.API.Models
{
    public class ToiletService
    {

        public List<Toilet> toilets = new List<Toilet>()
        {
            new Toilet{
                Id = 1, Location = "59.86029306150929, 17.638249261540285",
                Description = "Offentlig toalett i St. Per-gallerian, en trappa ner",
                IsFree = true,
                LastCleaned = DateTime.Today,
                Rating = new Rating{Average = 4.0, Count = 8 }
            },
            new Toilet
                {Id = 2, Location = "59.85821946252539, 17.646533452978318",
                Description = "Offentlig toalett i stationshuset, bottenplan, kortbetalning",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-14),
                Rating = new Rating{Average = 2.3, Count = 25 }
            },
            new Toilet
                {Id = 1, Location = "59.85361904298998, 17.61361074332028",
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                Rating = new Rating{Average = 5.0, Count = 1}
            }
        };

        public List<Toilet> GetAll()
        {
            return toilets;
        }
    }
}
