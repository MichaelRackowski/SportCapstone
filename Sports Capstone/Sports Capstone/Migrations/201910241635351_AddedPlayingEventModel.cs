namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayingEventModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayingEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        PlayersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayersId, cascadeDelete: true)
                .Index(t => t.PlayersId);
            
            AddColumn("dbo.Players", "PlayingEvent_Id", c => c.Int());
            CreateIndex("dbo.Players", "PlayingEvent_Id");
            AddForeignKey("dbo.Players", "PlayingEvent_Id", "dbo.PlayingEvents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayingEvents", "PlayersId", "dbo.Players");
            DropForeignKey("dbo.Players", "PlayingEvent_Id", "dbo.PlayingEvents");
            DropIndex("dbo.PlayingEvents", new[] { "PlayersId" });
            DropIndex("dbo.Players", new[] { "PlayingEvent_Id" });
            DropColumn("dbo.Players", "PlayingEvent_Id");
            DropTable("dbo.PlayingEvents");
        }
    }
}
