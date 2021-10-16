using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KissKartan.API.Models
{
    public class RatingService
    {
        ToiletContext db = new ToiletContext();
        
        public void Add(Rating r)
        {
            db.Add(r);
            db.SaveChanges();
        }

        public Rating Get(int id)
        {
            return db.Ratings.SingleOrDefault(o => o.Id == id);
        }

        public List<Rating> GetAll()
        {
            return db.Ratings.ToList();
        }

        public void Remove(Rating r)
        {
            db.Remove(r);
            db.SaveChanges();
        }

        public void Update(Rating r)
        {
            db.Update(r);
            db.SaveChanges();
        }


        public double GetAverage(int toiletId)
        {

            return db.Ratings.Where(o => o.Toilet.Id == toiletId).Select(o => o .Stars).Average();
        }


    }
}
