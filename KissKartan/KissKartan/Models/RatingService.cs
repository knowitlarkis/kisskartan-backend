using KissKartan.API.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KissKartan.API.Models
{
    public class RatingService
    {

        public void Add(Rating r) => RATINGTABLE.Add(r);

        public List<Rating> GetAll()
        {
            return RATINGTABLE.GetAll();
        }


        public double GetAverage(int toiletId)
        {
            var ratings = RATINGTABLE.GetAll().Where(o => o.Toilet.Id == toiletId).ToList();
            Console.WriteLine(ratings);
            if (ratings.Count != 0)
                return ratings.Select(o => o.Stars).Average();
            return 0;
        }


    }
}
