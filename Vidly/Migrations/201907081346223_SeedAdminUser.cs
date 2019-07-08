namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers]
           ([Id]
           ,[DrivingLicense]
           ,[Phone]
           ,[Email]
           ,[EmailConfirmed]
           ,[PasswordHash]
           ,[SecurityStamp]
           ,[PhoneNumber]
           ,[PhoneNumberConfirmed]
           ,[TwoFactorEnabled]
           ,[LockoutEndDateUtc]
           ,[LockoutEnabled]
           ,[AccessFailedCount]
           ,[UserName])
     VALUES
           ('4bcfe571-12c3-45f0-b58f-13b2ab3c70a3','666666','12345678900', 
            'Admin@Vidly.com', 0, 'AEf0+O3afqW1Qf7qVgbg3KoP8pgpDVum7CoR9idBRLV87ayxzjg1jT0yhdZGUaJ4FA==', 
            '37185fc6-a555-4f2e-bc81-dccdf17136e0',
            NULL,0,0,NULL,1,0,'Admin@Vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles]
           ([Id]
           ,[Name])
     VALUES
           ('002149bf-a118-454d-8f1b-57482c192c71', 'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles]
           ([UserId]
           ,[RoleId])
     VALUES
           ('4bcfe571-12c3-45f0-b58f-13b2ab3c70a3', '002149bf-a118-454d-8f1b-57482c192c71')");

        }
        
        public override void Down()
        {
        }
    }
}
