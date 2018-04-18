namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Carts", new[] { "Album_Id" });
            AlterColumn("dbo.Carts", "Album_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "Album_Id");
            AddForeignKey("dbo.Carts", "Album_Id", "dbo.Albums", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Carts", new[] { "Album_Id" });
            AlterColumn("dbo.Carts", "Album_Id", c => c.Int());
            CreateIndex("dbo.Carts", "Album_Id");
            AddForeignKey("dbo.Carts", "Album_Id", "dbo.Albums", "Id");
        }
    }
}
