
using Microsoft.AspNetCore.Mvc;
using SSLAPI.Interfaces;

namespace SSLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            this._pokemonRepository = pokemonRepository;
        }

        [HttpGet("GetPokemon")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PokemonController>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(pokemons);
        }

        [HttpGet("webhook")]
        public IActionResult VerifyWebhook(string hubMode, string hubVerifyToken, string hubChallenge)
        {
            if (hubMode == "subscribe" && hubVerifyToken == "LENGZAI")
            {
                return Ok(hubChallenge);
            }
            else
            {
                return BadRequest();
            }
        }


    }
}
