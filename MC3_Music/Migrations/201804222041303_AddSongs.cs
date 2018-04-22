namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSongs : DbMigration
    {
        public override void Up()
        {
            //the cure - disintegration
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Plainsong', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Pictures of you', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Closedown', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Lovesong', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Last Dance', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Lullaby', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fascination Street', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Prayers for Rain', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Same Deep Water as You', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Homesick', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Untitled', 9)");

            //The smashing pumpkins - melancholy and the infinite sadness
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Mellon Collie and the Infinite Sadness', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Tonight, Tonight', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Jellybelly', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Zero', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Here is No Why', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bullet with Butterfly Wings', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('To Forgive', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fuck You(An Ode to No One)', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Love', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Cupid de Locke', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Love', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Galapogos', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Muzzle', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Porcelina of the Vast Oceans', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Take Me Down', 10)");

            // Good Kid maad city
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Sherane a.k.a Master Splinters Daughter', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bitch Dont Kill My Vibe', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Backseat Freestyle', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Art of Peer Pressure', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Money Trees', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Poetic Justice', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Good Kid', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('M.A.A.D. City', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Swimming Pools (Drank)', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Sing About Me, Im Dying of Thirst', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Real', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Compton', 11)");

            // the big revival
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Big Revival', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Drink It Up', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Til Its Gone', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('American Kids', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Wild Child', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Beer Can Chicken', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Rock Bottom', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Dont It', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Save It for a Rainy Day', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Flora-Bama', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('If This Bus Could Talk', 12)");

            // feels like today
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Where You Are', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bless the Broken Road', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Then I Did', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Feels Like Today', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fast Cars and Freedom', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('When the Sand Runs Out', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Heres to You', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Day Before You', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Break Away', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Holes', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Oklahoma-Texas Line', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Skin', 13)");

            // At folsum prison
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Folsum Prison Blues', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('I Still Miss Someone', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Cocaine', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('25 Minutes to Go', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Orange Blossom Special', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Long Black Veil', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Send a Picture of Mother', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Wall', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Dirty Old Egg-Suckin Dog', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Flushed From the Bathrrom of Your Heart', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Jackson', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Give My Love to Rose', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('I Got Stripes', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Green, Green Grass of Home', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Greystone Chapel', 14)");

            //Stand Still, Look Pretty

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Leave the Pieces', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Way Back Home', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Good Kind', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Tennessee', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('My Oh My', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Stand Still, Look Pretty', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Cigarettes', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hard to Love you', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Lay Me Down', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('One More Girl', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Rain', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Crazy People', 15)");

            // oxymoron
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Gangsta', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Los Awesome', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Collard Greens', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('What They Want', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hoover Street', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Studio', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Prescription/Oxymoron', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Purge', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Blind Threats', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hell of a Night', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Break the Bank', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Man of the Year', 16)");


            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Act. 1', 17)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Act. 2', 17)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Act. 3', 17)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Das Rheingold', 18)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Die Walkure', 18)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Siegfried', 18)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Gotterdammerung', 18)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Concerte. 1', 19)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Concerte. 2', 19)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Concerte. 3', 19)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 1', 20)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 2', 20)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 3', 20)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 4', 20)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 5', 20)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 1', 21)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 2', 21)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 3', 21)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 4', 21)");
        }
        
        public override void Down()
        {
        }
    }
}
