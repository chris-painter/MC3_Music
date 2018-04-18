namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumPriceQuantity : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Albums SET Price = 29.99, Stock = 1000 WHERE Id = 1");
            Sql("UPDATE Albums SET Price = 19.99, Stock = 1000 WHERE Id = 2");
            Sql("UPDATE Albums SET Price = 29.99, Stock = 1000 WHERE Id = 3");
            Sql("UPDATE Albums SET Price = 29.99, Stock = 1000 WHERE Id = 4");
            Sql("UPDATE Albums SET Price = 39.99, Stock = 1000 WHERE Id = 5");


        }

        public override void Down()
        {
        }
    }
}
