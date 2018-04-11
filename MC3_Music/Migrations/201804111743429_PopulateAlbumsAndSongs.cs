namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAlbumsAndSongs : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL) VALUES ('Dark Side of the Moon', 'Pink Floyd', 'Rock', 10, 4, 'https://cdn-images-1.medium.com/max/1240/1*8FkvzbSdSJ4HNxtuZo5kLg.jpeg')");
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL) VALUES ('Hotel California', 'The Eagles', 'Rock', 15, 5, 'https://upload.wikimedia.org/wikipedia/en/thumb/4/49/Hotelcalifornia.jpg/220px-Hotelcalifornia.jpg')");
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL) VALUES ('Straight Outta Compton', 'N.W.A.', 'Rap', 30, 4, 'https://images-na.ssl-images-amazon.com/images/I/51x-aPEbhiL._SY355_.jpg')");

        }

        public override void Down()
        {
        }
    }
}
