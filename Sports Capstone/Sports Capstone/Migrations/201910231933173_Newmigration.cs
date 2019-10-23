namespace Sports_Capstone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Newmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportName = c.String(),
                        TypeOfPlay = c.String(),
                        SkillLevel = c.String(),
                        PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sports", "PlayerId", "dbo.Players");
            DropIndex("dbo.Sports", new[] { "PlayerId" });
            DropTable("dbo.Sports");
        }
    }
}
