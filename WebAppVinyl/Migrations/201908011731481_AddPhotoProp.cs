namespace WebAppVinyl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhotoProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vinyls", "Image", c => c.String());
            AddColumn("dbo.Vinyls", "AudioClip", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vinyls", "AudioClip");
            DropColumn("dbo.Vinyls", "Image");
        }
    }
}
