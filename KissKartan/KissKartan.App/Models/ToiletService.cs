using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissKartan.App.Models
{
    public class ToiletService
    {

        public List<Toilet> toilets = new List<Toilet>()
        {
            new Toilet{
                Id = 1, Location = "Dragarbrunnsgatan 16",
                Description = "Offentlig toalett i galleria, kräver kod från kafét",
                IsFree = true,
                LastCleaned = DateTime.Today,
                Rating = new Rating{Average = 3.7, Count = 8 }
            },
            new Toilet
                {Id = 2, Location = "Mynttorget 5",
                Description = "Offentlig toalett, fristående på torget, betala med kort",
                IsFree = false,
                LastCleaned = DateTime.Today.AddDays(-14),
                Rating = new Rating{Average = 2.3, Count = 25 }
            },
            new Toilet
                {Id = 1, Location = "Klaragatan 1",
                Description = "Pissoar mitt på trottoaren",
                IsFree = true,
                LastCleaned = DateTime.Today.AddYears(-10),
                Rating = new Rating{Average = 0.5, Count = 193 }
            }
        };

        public List<Toilet> GetAll()
        {
            return toilets;
        }
    }
}
