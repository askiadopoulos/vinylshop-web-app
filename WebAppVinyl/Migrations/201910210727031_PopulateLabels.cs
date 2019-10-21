namespace WebAppVinyl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateLabels : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Labels VALUES ('EMI')");
            Sql("INSERT INTO Labels VALUES ('Sony Music')");
            Sql("INSERT INTO Labels VALUES ('Polygram')");
            Sql("INSERT INTO Labels VALUES ('RCA')");
        }
        
        public override void Down()
        {
        }
    }
}
