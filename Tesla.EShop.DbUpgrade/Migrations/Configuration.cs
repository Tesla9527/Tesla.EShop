using System.Data.Entity.Migrations;

namespace Tesla.EShop.DbUpgrade.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Tesla.EShop.DbUpgrade.EfDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Tesla.EShop.DbUpgrade.EfDbContext context)
        {
            // do nothing...                       
        }
    }
}
