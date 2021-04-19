namespace WebApplicationRs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commentaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Restoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sondages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Commentaire_Id = c.Int(),
                        Utilisateur_Id = c.Int(),
                        Sondage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Commentaires", t => t.Commentaire_Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .ForeignKey("dbo.Sondages", t => t.Sondage_Id)
                .Index(t => t.Commentaire_Id)
                .Index(t => t.Utilisateur_Id)
                .Index(t => t.Sondage_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "Sondage_Id", "dbo.Sondages");
            DropForeignKey("dbo.Votes", "Utilisateur_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.Votes", "Commentaire_Id", "dbo.Commentaires");
            DropIndex("dbo.Votes", new[] { "Sondage_Id" });
            DropIndex("dbo.Votes", new[] { "Utilisateur_Id" });
            DropIndex("dbo.Votes", new[] { "Commentaire_Id" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Votes");
            DropTable("dbo.Sondages");
            DropTable("dbo.Restoes");
            DropTable("dbo.Commentaires");
        }
    }
}
