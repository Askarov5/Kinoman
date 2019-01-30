namespace Kinoman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, Name) VALUES(1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(5, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(6, 'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(7, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(8, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(9, 'Advanture')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(10, 'Animated Cartoons')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
