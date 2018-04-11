namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSongTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SongTitle = c.String(),
                        album_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.album_Id)
                .Index(t => t.album_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "album_Id", "dbo.Albums");
            DropIndex("dbo.Songs", new[] { "album_Id" });
            DropTable("dbo.Songs");
        }
    }
}
