using Microsoft.EntityFrameworkCore;

namespace SSLAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
