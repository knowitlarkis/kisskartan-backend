using KissKartan.API.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissKartan.API.Models
{
    public class ToiletService
    {
        public ToiletService()
        {
            TOILETTABLE.RegisterIds();
        }
        public List<Toilet> GetAll()
        {
            return TOILETTABLE.GetAll();
        }

        public Toilet Get(int id)
        {
            return TOILETTABLE.GetAll().SingleOrDefault(o => o.Id == id);
        }
    }
}
