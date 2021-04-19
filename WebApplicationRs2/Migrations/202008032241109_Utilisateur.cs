namespace WebApplicationRs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Utilisateur : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "MotDePasse", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilisateurs", "MotDePasse");
        }
    }
}
