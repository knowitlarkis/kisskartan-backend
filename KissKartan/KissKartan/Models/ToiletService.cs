using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissKartan.API.Models
{
    public class ToiletService
    {
        ToiletContext db = new ToiletContext();

        public List<Toilet> GetAll()
        {
            return db.Toilets.ToList();
        }

        public Toilet Get(int id)
        {
            return db.Toilets.SingleOrDefault(o => o.Id == id);
        }

        public void Add(Toilet t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public void Remove(Toilet t)
        {
            db.Remove(t);
            db.SaveChanges();
        }
    }
}
