namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMessageBoardModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessageBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Messages = c.String(),
                        PlayingEventId = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PlayingEvents", t => t.PlayingEventId)
                .Index(t => t.PlayingEventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MessageBoards", "PlayingEventId", "dbo.PlayingEvents");
            DropIndex("dbo.MessageBoards", new[] { "PlayingEventId" });
            DropTable("dbo.MessageBoards");
        }
    }
}
