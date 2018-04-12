namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTransactionsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        Album_Id = c.Int(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.Album_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Album_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Transactions", "Album_Id", "dbo.Albums");
            DropIndex("dbo.Transactions", new[] { "Customer_Id" });
            DropIndex("dbo.Transactions", new[] { "Album_Id" });
            DropTable("dbo.Transactions");
        }
    }
}
