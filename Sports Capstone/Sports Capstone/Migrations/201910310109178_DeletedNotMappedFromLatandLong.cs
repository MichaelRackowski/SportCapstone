namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedNotMappedFromLatandLong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayingEvents", "lat", c => c.Double(nullable: false));
            AddColumn("dbo.PlayingEvents", "lng", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlayingEvents", "lng");
            DropColumn("dbo.PlayingEvents", "lat");
        }
    }
}
