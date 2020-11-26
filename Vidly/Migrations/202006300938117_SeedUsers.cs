namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2e39e039-2502-406a-ad27-9ddf23b65715', N'admin@vidly.com', 0, N'AKjGa6TJIUlkuxK6VSGV2MmY6AkfmMB7fzLZzQINvGsreWHFeXoPtgM805es5+OECA==', N'd1996d3d-331f-4731-bb9a-2ef5834ac9ce', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65337f31-187c-4071-ae19-777237174384', N'guest@vidly.com', 0, N'AK0VgMo8NAUhzW0v/slxUQXtNQ/ty4utEQD+4ILIrV8zZ7bwlM8/8U387CqJWJoeyQ==', N'f8a8e54e-cdbc-4cfe-8261-3a9ae36245f6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ff4f24b5-0a2d-4700-aedd-8ffc038be3a2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2e39e039-2502-406a-ad27-9ddf23b65715', N'ff4f24b5-0a2d-4700-aedd-8ffc038be3a2')
");
        }
        
        public override void Down()
        {
        }
    }
}
