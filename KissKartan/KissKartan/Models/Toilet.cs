using System;

namespace KissKartan.API.Models
{
    public class Toilet
    {
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Description { get; set; }
        public bool IsFree { get; set; }
        public bool IsPublic { get; set; }
        public bool IsUrinal { get; set; }
        public bool IsAccessible { get; set; }
        public bool IsBaby { get; set; }
        public DateTime LastCleaned { get; set; }
        public double DistanceTo { get; set; }
        public string Image { get; set; }
        public double Rating { get; set; }
    }

}
