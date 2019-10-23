namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPlayerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "ApplicationId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Players", "ApplicationId");
            AddForeignKey("dbo.Players", "ApplicationId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Players", new[] { "ApplicationId" });
            DropColumn("dbo.Players", "ApplicationId");
        }
    }
}
