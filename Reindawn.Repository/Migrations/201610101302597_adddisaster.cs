namespace Reindawn.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddisaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DisasterLocation",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        RespondentId = c.Guid(),
                        Lat = c.Decimal(nullable: false, precision: 9, scale: 6),
                        Lng = c.Decimal(nullable: false, precision: 9, scale: 6),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        DatePosted = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DisasterLocation");
        }
    }
}
