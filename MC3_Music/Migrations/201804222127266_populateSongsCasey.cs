namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateSongsCasey : DbMigration
    {
        public override void Up()
        {
            //the cure - disintegration
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Plainsong', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Pictures of you', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Closedown', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Lovesong', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Last Dance', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Lullaby', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fascination Street', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Prayers for Rain', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Same Deep Water as You', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Homesick', 6)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Untitled', 6)");

            //The smashing pumpkins - melancholy and the infinite sadness
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Mellon Collie and the Infinite Sadness', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Tonight, Tonight', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Jellybelly', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Zero', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Here is No Why', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bullet with Butterfly Wings', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('To Forgive', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fuck You(An Ode to No One)', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Love', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Cupid de Locke', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Love', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Galapogos', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Muzzle', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Porcelina of the Vast Oceans', 7)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Take Me Down', 7)");

            // Good Kid maad city
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Sherane a.k.a Master Splinters Daughter', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bitch Dont Kill My Vibe', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Backseat Freestyle', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Art of Peer Pressure', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Money Trees', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Poetic Justice', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Good Kid', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('M.A.A.D. City', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Swimming Pools (Drank)', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Sing About Me, Im Dying of Thirst', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Real', 8)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Compton', 8)");

            // the big revival
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Big Revival', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Drink It up', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Til Its Gone', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('American Kids', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Wild Child', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Beer Can Chicken', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Rock Bottom', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Dont It', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Save It for a Rainy Day', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Flora-Bama', 9)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('If This Bus Could Talk', 9)");

            // feels like today
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Where You Are', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bless the Broken Road', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Then I Did', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Feels Like Today', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Fast Cars and Freedom', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('When the Sand Runs Out', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Heres to You', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Day Before You', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Break Away', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Holes', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Oklahoma-Texas Line', 10)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Skin', 10)");

            // At folsum prison
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Folsum Prison Blues', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('I Still Miss Someone', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Cocaine', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('25 Minutes to Go', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Orange Blossom Special', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Long Black Veil', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Send a Picture of Mother', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Wall', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Dirty Old Egg-Suckin Dog', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Flushed From the Bathrrom of Your Heart', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Jackson', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Give My Love to Rose', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('I Got Stripes', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Green, Green Grass of Home', 11)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Greystone Chapel', 11)");

            //Stand Still, Look Pretty

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Leave the Pieces', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Way Back Home', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Good Kind', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Tennessee', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('My; Oh My', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Stand Still, Look Pretty', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Cigarettes', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hard to Love you', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Lay Me Down', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('One More Girl', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Rain', 12)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Crazy People', 12)");

            // oxymoron
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Gangsta', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Los Awesome', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Collard Greens', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('What They Want', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hoover Street', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Studio', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Prescription/Oxymoron', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('The Purge', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Blind Threats', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Hell of a Night', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Break the Bank', 13)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Man of the Year', 13)");


            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Act. 1', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Act. 2', 14)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Act. 3', 14)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Das Rheingold', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Die Walkure', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Siegfried', 15)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Gotterdammerung', 15)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Concerte. 1', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Concerte. 2', 16)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Concerte. 3', 16)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 1', 17)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 2', 17)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 3', 17)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 4', 17)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Bach Kantatentwerk Vol. 5', 17)");

            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 1', 18)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 2', 18)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 3', 18)");
            Sql("INSERT INTO Songs (SongTitle, album_Id) VALUES ('Nocturne Vol. 4', 18)");
        }
        
        public override void Down()
        {
        }
    }
}
