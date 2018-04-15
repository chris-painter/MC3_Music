namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAlbumsWithPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Price");
        }
    }
}
