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
        //

        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        bool Save();
        // Put
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // Delete
        bool DeletePokemon(Pokemon pokemon);

    }
}
