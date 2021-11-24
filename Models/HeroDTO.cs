using System.ComponentModel.DataAnnotations;

namespace HeroesAPI.Models
{
    public class HeroDTO
    {
        public string Name { get; set; }
        public PowerType PowerType { get; set; }
        public string Power { get; set; }   
        [Range(1,10)]      
        public int HeroRanking { get; set; }
        public int CityId { get; set; }
    }
}