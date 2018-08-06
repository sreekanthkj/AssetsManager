namespace Assets.Repositoty.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baseline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Email = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 256),
                        DateOfBirth = c.DateTime(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 256),
                        Phone = c.String(nullable: false, maxLength: 128),
                        IsActive = c.String(nullable: false, maxLength: 1, unicode: false),
                        CreateDateTime = c.DateTime(nullable: false),
                        CreatedUser = c.String(nullable: false, maxLength: 128),
                        ModifiedDateTime = c.DateTime(nullable: false),
                        ModifiedUser = c.String(nullable: false, maxLength: 128),
                        RecordTs = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApplicationUsers");
        }
    }
}
