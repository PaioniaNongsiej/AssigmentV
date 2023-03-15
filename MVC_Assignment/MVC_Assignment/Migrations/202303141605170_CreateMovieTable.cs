namespace MVC_Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        mid = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        DateOfRelease = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.mid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
