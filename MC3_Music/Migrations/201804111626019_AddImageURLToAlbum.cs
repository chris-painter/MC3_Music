namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageURLToAlbum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "ImageURL");
        }
    }
}
