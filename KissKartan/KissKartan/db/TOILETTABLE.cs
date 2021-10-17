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
                X = 17.63,
                Y = 59.86,
                Description = "Annars är det en bra spelare med möjlighet att nå ut på nätet. Fin bild och här inget att klaga på. Att den inte klarar dvd regionsfri hade jag hoppats på. Ingen nämnde det",
                IsFree = false,
                IsPublic = false,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = true,
                Image = "https://cdn.pixabay.com/photo/2014/02/13/11/56/wc-265278_1280.jpg",
                LastCleaned = DateTime.Today,
                DistanceTo = 84,
                Rating = 1.2
            },
            new Toilet
            {
         X = 17.64,
                Y = 59.86,
                Description = "I really expected to love Colm Toibin's 'The Master' -- I've liked other books by Toibin and I like Henry James. But I was somewhat disappointed because this really never came together for me. I found ... Läs hela recensionen",
                IsFree = false,
                IsPublic = false,
                IsUrinal = false,
                IsAccessible = false,
                IsBaby = false,
                Image = "https://cdn.pixabay.com/photo/2014/09/20/08/01/bathroom-453420_1280.png",
                LastCleaned = DateTime.Today.AddDays(-14),
                DistanceTo = 46,
                Rating = 2.6
            },
            new Toilet
            {
                X = 17.65,
                Y = 59.86,
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = true,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = false,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/berlin-gendarmenmarkt-klo-stuga-382930/",
                Rating = 4.4
            },
            new Toilet
            {
                X = 17.65,
                Y = 59.87,
                Description = "Offentlig toalett i St. Per-gallerian, en trappa ner",
                IsFree = false,
                IsPublic = false,
                IsUrinal = false,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toalett-urinoar-offentliga-100783/",
                Rating = 3.8

            },
            new Toilet
            {
                X = 17.65,
                Y = 59.88,
                Description = "Offentlig toalett i stationshuset, bottenplan, kortbetalning",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toalett-urinoar-offentliga-100782/",
                Rating = 4.9
            },
            new Toilet
            {
                X = 17.59,
                Y = 59.89,
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toalett-toalett-hus-latrin-d%c3%b6rr-3368695/",
                Rating = 2
            },
            new Toilet
            {
                X = 17.66,
                Y = 59.90,
                Description = "Låset funkar ej och spolknappen är dålig.",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toaletter-toalett-rent-265278/",
                Rating = 4.1

            },
            new Toilet
            {
                X = 17.66,
                Y = 59.88,
                Description = "Bås med pissoarer, tvål från rituals så händerna luktar extra gott efter ett besök här",
                IsFree = false,
                IsPublic = false,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/d%c3%b6rr-toalettd%c3%b6rr-lugn-och-ro-1229144/",
                Rating = 1.3
            },
            new Toilet
            {
                X = 17.61,
                Y = 59.81,
                Description = "Bajjamajja, låst öppen från 4-22",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/badrum-f%c3%b6rfallen-f%c3%b6rfall-renovering-691341/",
                Rating = 1.7
            },
            new Toilet
            {
                X = 17.62,
                Y = 59.99,
                Description = "3 skötbord och handtork.",
                IsFree = false,
                IsPublic = true,
                IsUrinal = false,
                IsAccessible = true,
                IsBaby = true,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toaletter-toalett-rent-265275/",
                Rating = 3.5
            },
            new Toilet
            {
                X = 17.66,
                Y = 59.89,
                Description = "Toalett inne i galleria, mensskydd finns tillgängligt",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/illustrations/badrum-toalett-tv%c3%a4ttrum-m%c3%a4n-453420/",
                Rating = 5
            },
            new Toilet
            {
                X = 17.65,
                Y = 59.85,
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toalett-urinoar-man-toalett-toa-2364071/",
                Rating = 1
            },
            new Toilet
            {
                X = 17.66,
                Y = 60.89,
                Description = "Hemma hos Christoffer, swisha för att komma in",
                IsFree = false,
                IsPublic = true,
                IsUrinal = true,
                IsAccessible = true,
                IsBaby = false,
                LastCleaned = DateTime.Today.AddDays(-3),
                DistanceTo = 30.3,
                Image = "https://pixabay.com/sv/photos/toalett-barri%c3%a4r-fri-toalett-111092/",
                Rating = 4.9
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
