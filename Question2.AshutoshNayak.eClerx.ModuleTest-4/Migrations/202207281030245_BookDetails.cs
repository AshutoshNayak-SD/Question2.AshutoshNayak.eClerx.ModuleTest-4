namespace Question2.AshutoshNayak.eClerx.ModuleTest_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISBN = c.String(),
                        BookName = c.String(),
                        Genre = c.String(),
                        AuthorName = c.String(),
                        PublishedDate = c.DateTime(nullable: false),
                        AddedDate = c.DateTime(nullable: false, defaultValueSql: "GetDate()"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookDetails");
        }
    }
}
