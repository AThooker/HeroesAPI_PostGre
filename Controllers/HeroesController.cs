using System.Threading.Tasks;
using HeroesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeroesAPI.Controllers
{
    [Route("api/Heroes")]
    [ApiController]
    public class HeroesController : Controller
    {
        private HeroesDbContext _ctx;
        public HeroesController(HeroesDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHero(HeroDTO model)
        {
            if(!ModelState.IsValid) return BadRequest();
            var hero = new Hero
            {
                Name = model.Name,
                PowerType = model.PowerType,
                Power = model.Power,
                HeroRanking = model.HeroRanking,
                CityId = model.CityId
            };
            _ctx.Heroes.Add(hero);
            await _ctx.SaveChangesAsync();
            return Created($"https://localhost/api/heroes/{hero.HeroId}", hero);
        }

        [HttpGet]
        public async Task<IActionResult> GetHeroes()
        {
            var heroes = await _ctx.Heroes.ToListAsync();
            return Ok(heroes);
        }
        [HttpGet]
        public async Task<IActionResult> GetHeroById(int id)
        {
            // if(id == null) return BadRequest();
            var hero = await _ctx.Heroes.FindAsync(id);
            if(hero == null) return NotFound();
            return Ok(hero);
        }
    }
}