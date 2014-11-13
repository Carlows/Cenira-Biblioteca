namespace CeniraBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updeit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "Status");
        }
    }
}
