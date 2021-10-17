using KissKartan.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KissKartan.API.db
{
    public class RATINGTABLE 
    {
        private static List<Rating> ratings = new List<Rating>()
        {
            new Rating
            {
                Id = 1,
                Stars = 4,
                Toilet = TOILETTABLE.Get(1)
            },
            new Rating
            {
                Id = 2,
                Stars = 3,
                Toilet = TOILETTABLE.Get(1)

            },
            new Rating
            {
                Id = 3,
                Stars = 2,
                Toilet = TOILETTABLE.Get(1)

            }
        };

        public static void Add(Rating r)
        {
            ratings.Add(r);
        }

        public static Rating Get(int i) => ratings[i];

        public static List<Rating> GetAll() => ratings;

        public static int Count() => ratings.Count;

        
    }
}
