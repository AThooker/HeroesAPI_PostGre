using System.Collections.Generic;

namespace HeroesAPI.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public List<Hero> Heroes {get; set;} = new List<Hero>();
        public City()
        {
            Heroes = new List<Hero>();
        }
    }
}