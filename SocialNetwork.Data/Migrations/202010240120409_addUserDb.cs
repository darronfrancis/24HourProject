namespace SocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "User_UserId", c => c.Guid());
            CreateIndex("dbo.Post", "User_UserId");
            AddForeignKey("dbo.Post", "User_UserId", "dbo.User", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post", "User_UserId", "dbo.User");
            DropIndex("dbo.Post", new[] { "User_UserId" });
            DropColumn("dbo.Post", "User_UserId");
        }
    }
}
