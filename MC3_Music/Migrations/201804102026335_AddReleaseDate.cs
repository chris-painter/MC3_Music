namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "DateReleased", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "DateReleased");
        }
    }
}
