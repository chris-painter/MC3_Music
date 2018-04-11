namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSongs : DbMigration
    {
        public override void Up()
        {
            //Michael Jackson - Thriller
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Wanna Be Startin Something', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Baby Be Mine', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Girl Is Mine', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Thriller', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Beat It', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Billie Jean', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Human Nature', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Pretty Young Thing', 1)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Lady In My Life', 1)");

            //Jason Aldean -Night Train
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('This Nothin Town', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('When She Says Baby', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Feel That Again', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Wheels Rollin', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Talk', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Only Way I Know', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Take a Little Ride', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('I Dont Do Lonely Well', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Night Train', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('1994', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Staring At The Sun', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Drink One For Me', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Black Tears', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Walking Away', 2)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Water Tower', 2)");














        }

        public override void Down()
        {
        }
    }
}
