namespace CafeOtomasyonu.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telephone = c.String(maxLength: 25, unicode: false),
                        Email = c.String(maxLength: 150, unicode: false),
                        Address = c.String(maxLength: 500, unicode: false),
                        Description = c.String(maxLength: 500, unicode: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesCode = c.String(maxLength: 15, unicode: false),
                        CustomerId = c.Int(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remainder = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 300, unicode: false),
                        EndProcessDate = c.DateTime(nullable: false),
                        PackageOrder = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuName = c.String(maxLength: 60, unicode: false),
                        Description = c.String(maxLength: 300, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        ProductNumber = c.String(maxLength: 15, unicode: false),
                        ProductName = c.String(maxLength: 50, unicode: false),
                        UnitPrice1 = c.Decimal(nullable: false, precision: 28, scale: 2),
                        UnitPrice2 = c.Decimal(nullable: false, precision: 28, scale: 2),
                        UnitPrice3 = c.Decimal(nullable: false, precision: 28, scale: 2),
                        Description = c.String(maxLength: 300, unicode: false),
                        Image = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.TableMovements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesCode = c.String(maxLength: 15, unicode: false),
                        TableId = c.Int(),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 300, unicode: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Tables", t => t.TableId)
                .Index(t => t.TableId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableName = c.String(maxLength: 15, unicode: false),
                        Description = c.String(maxLength: 300, unicode: false),
                        Status = c.Boolean(nullable: false),
                        Rezerv = c.Boolean(nullable: false),
                        SavedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdateDate = c.DateTime(nullable: false),
                        Process = c.String(),
                        OrderCode = c.String(maxLength: 20, unicode: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 100, unicode: false),
                        Telephone = c.String(maxLength: 15, unicode: false),
                        Address = c.String(maxLength: 500, unicode: false),
                        Email = c.String(maxLength: 150, unicode: false),
                        Mission = c.String(maxLength: 50, unicode: false),
                        UserName = c.String(maxLength: 50, unicode: false),
                        Password = c.String(maxLength: 20, unicode: false),
                        ReminderQuestion = c.String(maxLength: 150, unicode: false),
                        Reply = c.String(maxLength: 50, unicode: false),
                        Description = c.String(maxLength: 300, unicode: false),
                        SavedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Admin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserMovements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Description = c.String(maxLength: 300, unicode: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OrderCode",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDefinition = c.String(maxLength: 20, unicode: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesCode = c.String(maxLength: 15, unicode: false),
                        SalesType = c.String(maxLength: 50, unicode: false),
                        Paid = c.Decimal(nullable: false, precision: 28, scale: 2),
                        Description = c.String(maxLength: 300, unicode: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rollers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FormName = c.String(maxLength: 50, unicode: false),
                        ControlName = c.String(maxLength: 50, unicode: false),
                        ControlCaption = c.String(maxLength: 50, unicode: false),
                        Visible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SettingDefinition = c.String(),
                        SettingName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableMovements", "TableId", "dbo.Tables");
            DropForeignKey("dbo.Tables", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserMovements", "UserId", "dbo.Users");
            DropForeignKey("dbo.TableMovements", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "MenuId", "dbo.Menu");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.UserMovements", new[] { "UserId" });
            DropIndex("dbo.Tables", new[] { "UserId" });
            DropIndex("dbo.TableMovements", new[] { "ProductId" });
            DropIndex("dbo.TableMovements", new[] { "TableId" });
            DropIndex("dbo.Product", new[] { "MenuId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropTable("dbo.Settings");
            DropTable("dbo.Rollers");
            DropTable("dbo.PaymentTransactions");
            DropTable("dbo.OrderCode");
            DropTable("dbo.UserMovements");
            DropTable("dbo.Users");
            DropTable("dbo.Tables");
            DropTable("dbo.TableMovements");
            DropTable("dbo.Product");
            DropTable("dbo.Menu");
            DropTable("dbo.Sales");
            DropTable("dbo.Customers");
        }
    }
}
