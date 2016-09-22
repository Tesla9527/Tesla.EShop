using System.Data.Entity;
using Tesla.EShop.Model.Tables;

namespace Tesla.EShop.DbUpgrade
{
    public class EfDbContext : DbContext
    {      
       public DbSet<User> Users { get; set; }
    }
}