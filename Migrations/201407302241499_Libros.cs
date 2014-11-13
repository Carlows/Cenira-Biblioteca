namespace CeniraBiblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Libros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Author = c.String(nullable: false),
                        Publisher = c.String(nullable: false),
                        Pages = c.Int(nullable: false),
                        DatePublished = c.DateTime(nullable: false),
                        Edition = c.Int(nullable: false),
                        ImageURL = c.String(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Book", "CategoryID", "dbo.Category");
            DropIndex("dbo.Book", new[] { "CategoryID" });
            DropTable("dbo.Category");
            DropTable("dbo.Book");
        }
    }
}
