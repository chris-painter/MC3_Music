namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAlbumTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "Genre", c => c.String());
            DropColumn("dbo.Albums", "DateReleased");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "DateReleased", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Albums", "Genre", c => c.Int(nullable: false));
        }
    }
}
