using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);

        ICollection<Owner> GetOwnerOfAPokemon(int ownerId); 

        ICollection<Pokemon> GetPokemonByOwner(int ownerId);

        bool OwnerExists(int ownerId);

    }
}
