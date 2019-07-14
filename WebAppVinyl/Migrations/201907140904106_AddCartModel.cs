namespace WebAppVinyl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCartModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        VinylId = c.Int(nullable: false),
                        BuyerId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.VinylId, t.BuyerId })
                .ForeignKey("dbo.AspNetUsers", t => t.BuyerId, cascadeDelete: true)
                .ForeignKey("dbo.Vinyls", t => t.VinylId)
                .Index(t => t.VinylId)
                .Index(t => t.BuyerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "VinylId", "dbo.Vinyls");
            DropForeignKey("dbo.Carts", "BuyerId", "dbo.AspNetUsers");
            DropIndex("dbo.Carts", new[] { "BuyerId" });
            DropIndex("dbo.Carts", new[] { "VinylId" });
            DropTable("dbo.Carts");
        }
    }
}
