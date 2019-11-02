namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGoTheMessageClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MessageBoards", "PlayersId", c => c.Int());
            CreateIndex("dbo.MessageBoards", "PlayersId");
            AddForeignKey("dbo.MessageBoards", "PlayersId", "dbo.Players", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageBoards", "PlayersId", "dbo.Players");
            DropIndex("dbo.MessageBoards", new[] { "PlayersId" });
            DropColumn("dbo.MessageBoards", "PlayersId");
        }
    }
}
