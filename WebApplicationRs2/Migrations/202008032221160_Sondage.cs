namespace WebApplicationRs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sondage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Votes", "Sondage_Id", "dbo.Sondages");
            DropIndex("dbo.Votes", new[] { "Sondage_Id" });
            DropColumn("dbo.Votes", "Sondage_Id");
            DropTable("dbo.Sondages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sondages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Votes", "Sondage_Id", c => c.Int());
            CreateIndex("dbo.Votes", "Sondage_Id");
            AddForeignKey("dbo.Votes", "Sondage_Id", "dbo.Sondages", "Id");
        }
    }
}
