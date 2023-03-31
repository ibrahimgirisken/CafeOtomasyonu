namespace CafeOtomasyonu.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuName = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuUd = c.Int(nullable: false),
                        ProductNumber = c.String(maxLength: 20, unicode: false),
                        ProductName = c.String(),
                        UnitPrice1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuUd, cascadeDelete: true)
                .Index(t => t.MenuUd);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "MenuUd", "dbo.Menu");
            DropIndex("dbo.Urun", new[] { "MenuUd" });
            DropTable("dbo.Urun");
            DropTable("dbo.Menu");
        }
    }
}
