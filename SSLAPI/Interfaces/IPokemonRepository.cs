﻿using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(String name);
        decimal GetPokemonRating(int pokeId);

        bool PokemonExists(int pokeId);


    }
}
