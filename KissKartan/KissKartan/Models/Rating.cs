using System.ComponentModel.DataAnnotations;

namespace KissKartan.API.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [Range(1,5)]
        public int Stars { get; set; }
        public Toilet Toilet { get; set; }
    }
}