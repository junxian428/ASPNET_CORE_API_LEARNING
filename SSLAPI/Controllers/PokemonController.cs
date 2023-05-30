
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSLAPI.Dto;
using SSLAPI.Interfaces;
using SSLAPI.Models;
using System.Collections.Generic;

namespace SSLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        private readonly IMapper _mapper;
        public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this._pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        [HttpGet("GetPokemon")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PokemonController>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _mapper.Map<List<PokemonDto>>(_pokemonRepository.GetPokemons());
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

        [HttpGet("{pokeId}")]
        [ProducesResponseType(200,Type= typeof(Pokemon))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemon(int pokeId)
        {
            if(!_pokemonRepository.PokemonExists(pokeId))
                return NotFound();
            var pokemon = _mapper.Map<PokemonDto>(_pokemonRepository.GetPokemon(pokeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemon);
        }

        [HttpGet("{pokeId}/rating")]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400)]
        public IActionResult GetPokemonRating(int pokeId)
        {
            if(!_pokemonRepository.PokemonExists(pokeId))  
                return NotFound();
            

            var rating = _pokemonRepository.GetPokemonRating(pokeId);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(rating);


        }

    }
}
