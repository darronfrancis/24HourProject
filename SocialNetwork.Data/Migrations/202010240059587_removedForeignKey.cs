namespace SocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Post", "UserId", "dbo.User");
            DropIndex("dbo.Post", new[] { "UserId" });
            DropColumn("dbo.Post", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "UserId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Post", "UserId");
            AddForeignKey("dbo.Post", "UserId", "dbo.User", "UserId", cascadeDelete: true);
        }
    }
}
