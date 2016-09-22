namespace Tesla.EShop.DbUpgrade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Birthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Birthday");
        }
    }
}
