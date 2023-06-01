using SSLAPI.Models;

namespace SSLAPI.Interfaces
{
    public interface ICategoryRepository
    {
        // Read Object
        ICollection<Category> GetCategories();
        Category GetCategory(int id);

        ICollection<Pokemon> GetPokemonByCategory(int categoryId);


        bool CategoryExist(int id);

        // Create Object

        bool CreateCategory(Category category);

        bool Save();

        // Update API
        bool UpdateCategory(Category category);

        // Delete 
        bool DeleteCategory(Category category);


    }
}
