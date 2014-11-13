namespace CeniraBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class another2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pedidos", "book_BookID", "dbo.Book");
            DropIndex("dbo.Pedidos", new[] { "book_BookID" });
            RenameColumn(table: "dbo.Pedidos", name: "book_BookID", newName: "BookID");
            AlterColumn("dbo.Pedidos", "BookID", c => c.Int(nullable: false));
            CreateIndex("dbo.Pedidos", "BookID");
            AddForeignKey("dbo.Pedidos", "BookID", "dbo.Book", "BookID", cascadeDelete: true);
            DropColumn("dbo.Pedidos", "idLibro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pedidos", "idLibro", c => c.Int(nullable: false));
            DropForeignKey("dbo.Pedidos", "BookID", "dbo.Book");
            DropIndex("dbo.Pedidos", new[] { "BookID" });
            AlterColumn("dbo.Pedidos", "BookID", c => c.Int());
            RenameColumn(table: "dbo.Pedidos", name: "BookID", newName: "book_BookID");
            CreateIndex("dbo.Pedidos", "book_BookID");
            AddForeignKey("dbo.Pedidos", "book_BookID", "dbo.Book", "BookID");
        }
    }
}
