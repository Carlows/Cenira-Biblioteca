namespace CeniraBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class another : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Cedula = c.Int(nullable: false),
                        idLibro = c.Int(nullable: false),
                        book_BookID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Book", t => t.book_BookID)
                .Index(t => t.book_BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidos", "book_BookID", "dbo.Book");
            DropIndex("dbo.Pedidos", new[] { "book_BookID" });
            DropTable("dbo.Pedidos");
        }
    }
}
