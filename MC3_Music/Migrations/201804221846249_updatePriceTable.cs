namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePriceTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Price", c => c.Double(nullable: false));
        }
    }
}
