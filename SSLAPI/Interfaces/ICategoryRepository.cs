using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);

        ICollection<Pokemon> GetPokemonByCategory(int categoryId);


        bool CategoryExist(int id);

    }
}
