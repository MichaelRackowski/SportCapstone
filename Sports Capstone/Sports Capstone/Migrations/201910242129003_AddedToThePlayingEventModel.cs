namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToThePlayingEventModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayingEvents", "CurrentPlayers", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayingEvents", "CurrentPlayers");
        }
    }
}
