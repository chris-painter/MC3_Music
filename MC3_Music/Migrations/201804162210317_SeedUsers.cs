namespace MC3_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [FirstName], [LastName], [Email], [EmailConfirmed], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (N'37211d1b-142a-4d3c-97dc-224c2e14b82c', N'guest@mc3music.com', N'AJUVU62/olZMwBD6LR0QsaAktZPj2viHehkBcD0R1CXS+hGPjQJ3U0h0YBhzU0bfHQ==', N'65bfa98b-8f18-4de1-90e8-6081586323bf', N'Guest', N'Guest', N'guest@mc3music.com', 0, NULL, 0, 0, NULL, 1, 0)
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [FirstName], [LastName], [Email], [EmailConfirmed], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount]) VALUES (N'525ee5bc-2080-484e-bd64-e26ed45fdb5d', N'admin@mc3music.com', N'AMxBJmVATHC2r2qqBs3p7ASB1JnWp+hFO/mVtRuRYCHKwj0xqKwPVH8nbjjKcux41Q==', N'bcd3b1d0-4f5d-4ec4-8419-da6575f2f768', N'Admin', N'Admin', N'admin@mc3music.com', 0, NULL, 0, 0, NULL, 1, 0)
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b8f0cda3-c8b7-48f1-ae27-b51970343315', N'CanManageAlbums')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'525ee5bc-2080-484e-bd64-e26ed45fdb5d', N'b8f0cda3-c8b7-48f1-ae27-b51970343315')



");
        }
        
        public override void Down()
        {
        }
    }
}
