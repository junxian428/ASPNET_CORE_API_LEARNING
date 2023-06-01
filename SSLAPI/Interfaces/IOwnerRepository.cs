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
        //


        bool CreateOwner(Owner owner);

        bool Save();

        //
        bool UpdateOwner(Owner owner);

        // Delete

        bool DeleteOwner(Owner owner);

    }
}
