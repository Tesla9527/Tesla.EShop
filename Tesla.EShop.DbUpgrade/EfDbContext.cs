using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Tesla.EShop.Model.Tables;

namespace Tesla.EShop.DbUpgrade
{
    public class EfDbContext : IdentityDbContext<ApplicationUser>
    {
        public EfDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static EfDbContext Create()
        {
            return new EfDbContext();
        }

        public IDbSet<User> User { get; set; }

    }
}