namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedthingstoplayersmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "SelctedSport", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "SelctedSport");
        }
    }
}
