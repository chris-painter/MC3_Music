namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddAlbumsToAlbumsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Disintegration', 'The Cure', 'Rock', 1000, 5, 'http://ksassets.timeincuk.net/wp/uploads/sites/55/2015/04/2015TheCure_Disintegration_230415.jpg', 29.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Melancholy and the Infinite Sadness', 'The Smashing Pumpkins', 'Rock', 1000, 4, 'https://media.npr.org/assets/img/2012/12/07/mellon-collie-and-the-infinite-sadness---cover-art_custom-a7b8e04bc3d49db97a1d9aea22fd04581200e417-s900-c85.jpg', 29.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Good Kid, M.A.A.D City', 'Kendrick Lamar', 'Rap', 1000, 3, 'https://www.yurisrecords.com/wp-content/uploads/2017/02/kendrick-lamar-good-kid-mad-city.jpg', 19.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('The Big Revival', 'Kenny Chesney', 'Country', 1000, 4, 'https://countrymusicrocks.net/wp-content/uploads/2014/07/Kenny-Chesney-The-Big-Revival-CountryMusicRocks.net_.jpg', 29.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Feels Like Today', 'Rascal Flatts', 'Country', 000, 3, 'https://images.genius.com/3a145a857da130c80b2a03d0de286b0b.600x600x1.jpg', 19.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES('At Folsom Prison', 'Johnny Cash', 'Country', 1000, 4, 'https://img.wennermedia.com/920-width/rs-136897-af22084dc4088905a4eb9afab73bb7efc9ce780b.jpg', 19.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Stand Still, Look Pretty', 'The Wreckers', 'Country', 1000, 5, 'https://images-na.ssl-images-amazon.com/images/I/51tiZ-eQH4L.jpg', 29.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Oxymoron', 'Schoolboy Q', 'Rap', 1000, 4, 'https://i.pinimg.com/originals/69/92/17/69921763f48838f0c76af163cd3d810b.jpg', 19.99)");


            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Tristan and Isolde', 'Richard Wagner', 'Classical', 1000, 4, 'https://img.cdandlp.com/2016/02/imgL/118008070.jpg', 29.99)");

            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Der Ring Des Nibelung', 'Richard Wagner', 'Classical', 1000, 3, 'https://images-na.ssl-images-amazon.com/images/I/71vMVW8Cv3L._SL1500_.jpg', 39.99)");

            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Konzerte Concertos', 'Sebastion Bach', 'Classical', 1000, 3, 'https://images.eil.com/large_image/JOHANN_SEBASTIAN_BACH_CONCERTOS-534271.jpg', 29.99)");

            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Das Kantatenwerk', 'Sebastion Bach', 'Classical', 1000, 3, 'https://images.eil.com/large_image/JOHANN_SEBASTIAN_BACH_DAS%2BKANTATENWERK%3A%2BVOL.%2B4-535494.jpg', 29.99)");
            
            Sql("INSERT INTO Albums (Title, Artist, Genre, Stock, Rating, ImageURL, Price) VALUES ('Nocturnes', 'Claude Debussy', 'Classical', 1000, 3, 'https://images.991.com/large_image/Claude+Debussy+La+Mer++Nocturnes-526820.jpg', 39.99)");
        }

        public override void Down()
        {
        }
    }
}
