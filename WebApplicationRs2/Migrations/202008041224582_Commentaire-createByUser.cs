namespace WebApplicationRs2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentairecreateByUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Commentaires", "createByUser", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Commentaires", "createByUser");
        }
    }
}
