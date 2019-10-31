namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedMyPlayingEventsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayingEvents", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayingEvents", "Address");
        }
    }
}
