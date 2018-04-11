namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAlbumExample : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating) VALUES ('Thriller', 'Michael Jackson', 'Rock', 2, 3)");
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating) VALUES ('Night Train', 'Jason Aldean', 'Country', 4, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
