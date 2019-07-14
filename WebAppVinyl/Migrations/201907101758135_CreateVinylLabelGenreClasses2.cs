namespace WebAppVinyl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateVinylLabelGenreClasses2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vinyls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Artist = c.String(nullable: false, maxLength: 255),
                        Title = c.String(nullable: false, maxLength: 255),
                        ReleaseYear = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GenreId = c.Int(nullable: false),
                        LabelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Labels", t => t.LabelId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.LabelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vinyls", "LabelId", "dbo.Labels");
            DropForeignKey("dbo.Vinyls", "GenreId", "dbo.Genres");
            DropIndex("dbo.Vinyls", new[] { "LabelId" });
            DropIndex("dbo.Vinyls", new[] { "GenreId" });
            DropTable("dbo.Vinyls");
            DropTable("dbo.Labels");
            DropTable("dbo.Genres");
        }
    }
}
