namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSongs2 : DbMigration
    {
        public override void Up()
        {
            //Pink Floyd - Dark Side of the Moon
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Speak To Me', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Breathe (In The Air)', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('On The Run', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Time', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Great Gig In The Sky', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Money', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Us And Them', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Any Colour You Like', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Brain Damage', 3)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Eclipse', 3)");

            //The Eagles - Hotel California
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hotel California', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('New Kid In Town', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Life In The Fastlane', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Wasted Time', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Wasted Time (Reprise)', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Victim Of Love', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Pretty Maids All In A Row', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Try And Love Again', 4)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Last Resort', 4)");

            //N.W.A. - Straigh Outta Compton
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Straight Outta Compton', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fuck Tha Police', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Gangsta Gangsta', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('If It Aint Ruff', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Parental Discretion Iz Advised', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('8 Ball (Remix)', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Something Like That', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Express Yourself', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Comptons N The House (Remix)', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('I Aint Tha 1', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Dopeman (Remix)', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Quient On Tha Set', 5)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Something 2 Dance 2', 5)");

        }

        public override void Down()
        {
        }
    }
}
