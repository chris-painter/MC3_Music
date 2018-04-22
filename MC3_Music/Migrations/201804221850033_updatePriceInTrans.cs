namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePriceInTrans : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Price");
        }
    }
}
