using KissKartan.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KissKartan.API
{
    public class TOILETTABLE 
    {
        private static List<Toilet> toilets = new List<Toilet>
        {
            new Toilet
            {
                Position = new Position(59.86029306150929, 17.638249261540285).ToJson(),
                Description = "Offentlig toalett i St. Per-gallerian, en trappa ner",
                IsFree = true,
                IsPublic = false,
                IsUrinal = false,
                IsAccessible = true,
                IsBaby = true,
                LastCleaned = DateTime.Today,
                DistanceTo = 84
            },
            new Toilet
            {
         
                Position = new Position(59.85821946252539, 17.646533452978318).ToJson(),
                Description = "Offentlig toalett i stationshuset, bottenplan, kortbetalning",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = false,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-14),
                DistanceTo = 46
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            },
            new Toilet
            {
                Position = new Position(59.85361904298998, 17.61361074332028).ToJson(),
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3
            }

        };
        public static Toilet Get(int i) => toilets[i];

        public static List<Toilet> GetAll() => toilets;

        public static int Count() => toilets.Count;

        public static void RegisterIds()
        {
            var id = 1;
            foreach (var item in toilets)
            {
                item.Id = id++;
            }
        }


    }
}
