namespace Kinoman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "NumberInStock", c => c.Short(nullable: false));
            AddColumn("dbo.Movies", "ShortDecription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ShortDecription");
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
