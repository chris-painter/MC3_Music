namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCartTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Carts", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "Price", c => c.Double(nullable: false));
        }
    }
}
