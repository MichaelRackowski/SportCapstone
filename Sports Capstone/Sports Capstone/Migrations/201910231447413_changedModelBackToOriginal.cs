namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedModelBackToOriginal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "SelctedSport");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "SelctedSport", c => c.Int(nullable: false));
        }
    }
}
