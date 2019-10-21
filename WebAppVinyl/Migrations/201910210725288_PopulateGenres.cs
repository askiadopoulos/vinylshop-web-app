namespace WebAppVinyl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES ('Rock')");
            Sql("INSERT INTO Genres VALUES ('Pop')");
            Sql("INSERT INTO Genres VALUES ('Jazz')");
            Sql("INSERT INTO Genres VALUES ('Classic')");
        }
        
        public override void Down()
        {
        }
    }
}
