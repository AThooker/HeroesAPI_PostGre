using System.ComponentModel.DataAnnotations;

namespace HeroesAPI.Models
{
    public enum PowerType {
        Physical,
        Mental,
        Hybrid
    }
    public class Hero
    {
        public int HeroId { get; set; }
        public string Name { get; set; }
        public PowerType PowerType { get; set; }
        public string Power { get; set; }   
        [Range(1,10)]      
        public int HeroRanking { get; set; }
        public int CityId { get; set; }
    }
}