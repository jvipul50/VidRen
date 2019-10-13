namespace VidRen2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6c6b09de-5cf7-4e20-83c7-2c7eca4eaadf', N'admin@vidren.com', 0, N'ANwKPG9+u6tVX0/CGhY+8wCHhPWbWgfNoZpLPGumrwAE+ONiM/HOr3b6w9CbapS5Wg==', N'c1bfc8b7-c3cd-419a-944c-86e29a217cfb', NULL, 0, 0, NULL, 1, 0, N'admin@vidren.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'852ddac0-42c7-4176-a296-aaff2fa4b8e5', N'guest@vidren.com', 0, N'AGGAKL5BgnwOLmYwFPXHo1lc5+RNzsV5tLv+NStg300dxDcTmCqjsHsYlJQYNr8M8w==', N'646bdb07-6aab-4b1e-a0ae-3822b1ce7df4', NULL, 0, 0, NULL, 1, 0, N'guest@vidren.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c8cabc10-a852-409d-8fb1-747aea4f43b1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6c6b09de-5cf7-4e20-83c7-2c7eca4eaadf', N'c8cabc10-a852-409d-8fb1-747aea4f43b1')

");
        }
        
        public override void Down()
        {
        }
    }
}
