using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KissKartan.API.Models
{
    public class TypePropertyService
    {
        ToiletContext db = new ToiletContext();

        public void Add(TypeProperty t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public TypeProperty Get(int id)
        {
            return db.Types.FirstOrDefault(o => o.Id == id);
        }

        public List<TypeProperty> GetAll()
        {
            return db.Types.ToList();
        }

        public void Remove(TypeProperty t)
        {
            db.Remove(t);
            db.SaveChanges();
        }

        public void Update(TypeProperty t)
        {
            db.Update(t);
            db.SaveChanges();
        }
    }
}
