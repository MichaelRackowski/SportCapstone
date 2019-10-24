namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToThePlayingEventModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayingEvents", "SportName", c => c.String());
            AddColumn("dbo.PlayingEvents", "TypeOfPlay", c => c.String());
            AddColumn("dbo.PlayingEvents", "SkillLevel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayingEvents", "SkillLevel");
            DropColumn("dbo.PlayingEvents", "TypeOfPlay");
            DropColumn("dbo.PlayingEvents", "SportName");
        }
    }
}
