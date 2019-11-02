namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleanedUpMessageBoardClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MessageBoards", "FirstName");
            DropColumn("dbo.MessageBoards", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MessageBoards", "LastName", c => c.String());
            AddColumn("dbo.MessageBoards", "FirstName", c => c.String());
        }
    }
}
