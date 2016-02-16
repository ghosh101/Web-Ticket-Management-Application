namespace EventManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        eventId = c.Int(nullable: false, identity: true),
                        eventName = c.String(),
                        eventDate = c.DateTime(nullable: false),
                        isZone1 = c.String(),
                        isZone2 = c.String(),
                        isZone3 = c.String(),
                        isZone4 = c.String(),
                        isZone5 = c.String(),
                        isZone6 = c.String(),
                        isZone7 = c.String(),
                        isZone8 = c.String(),
                    })
                .PrimaryKey(t => t.eventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
