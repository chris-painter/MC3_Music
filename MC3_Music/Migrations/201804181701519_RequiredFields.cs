namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Albums", "Genre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Albums", "Genre", c => c.String());
            AlterColumn("dbo.Albums", "Title", c => c.String());
        }
    }
}
