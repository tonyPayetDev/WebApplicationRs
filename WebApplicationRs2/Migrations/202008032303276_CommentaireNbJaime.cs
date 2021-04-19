namespace WebApplicationRs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentaireNbJaime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commentaires", "nbJaime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commentaires", "nbJaime");
        }
    }
}
