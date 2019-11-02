namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToMEssageBoardClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MessageBoards", "Review", c => c.String());
            AddColumn("dbo.MessageBoards", "Rating", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MessageBoards", "Rating");
            DropColumn("dbo.MessageBoards", "Review");
        }
    }
}
