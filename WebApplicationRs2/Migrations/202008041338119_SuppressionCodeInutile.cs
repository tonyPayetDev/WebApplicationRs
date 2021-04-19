namespace WebApplicationRs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuppressionCodeInutile : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Restoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Restoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
