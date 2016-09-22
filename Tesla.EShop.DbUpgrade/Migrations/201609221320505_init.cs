namespace Tesla.EShop.DbUpgrade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Gender = c.Boolean(),
                        CreationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
