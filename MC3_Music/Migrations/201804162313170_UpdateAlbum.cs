namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAlbum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Transactions", new[] { "Album_Id" });
            AlterColumn("dbo.Transactions", "Album_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "Album_Id");
            AddForeignKey("dbo.Transactions", "Album_Id", "dbo.Albums", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Transactions", new[] { "Album_Id" });
            AlterColumn("dbo.Transactions", "Album_Id", c => c.Int());
            CreateIndex("dbo.Transactions", "Album_Id");
            AddForeignKey("dbo.Transactions", "Album_Id", "dbo.Albums", "Id");
        }
    }
}
