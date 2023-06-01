using SSLAPI.Data;
using SSLAPI.Interfaces;
using SSLAPI.Models;

namespace SSLAPI.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public Category GetCategory(int id)
        {
            return _context.Categories.Where(e=> e.Id == id).FirstOrDefault();

        }

        public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
        {
            return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();

        }


        public bool CategoryExist(int id)
        {

            return _context.Categories.Any(c => c.Id == id);

        }

        public bool CreateCategory(Category category)
        {
            // Change Tracker
            // Add , Updating, Modifying
            // Connected vs Disconnected
            // Connected more common
            // EntityState.Added = 
            // 
            _context.Add(category);

            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;

        }

        public bool UpdateCategory(Category category)
        {
            _context.Update(category);
            return Save();
        }

        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);
            return Save();
        }

      
    }
}
