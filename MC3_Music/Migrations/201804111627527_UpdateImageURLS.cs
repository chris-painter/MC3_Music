namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateImageURLS : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Albums SET ImageURL = 'https://images-na.ssl-images-amazon.com/images/I/81v2-V-jINL._SY355_.jpg' WHERE Id = 2");
            Sql("UPDATE Albums SET ImageURL = 'https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Michael_Jackson_-_Thriller.png/220px-Michael_Jackson_-_Thriller.png' WHERE Id = 1");

        }

        public override void Down()
        {
        }
    }
}
