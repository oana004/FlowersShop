namespace FlorariaPOCData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInstall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderProduct",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfProducts = c.Int(nullable: false),
                        Order_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderStatus = c.String(),
                        OrderDetails = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        Payment_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payment", t => t.Payment_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Payment_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CVV = c.Int(nullable: false),
                        AccountNumber = c.String(),
                        CardExpirationDate = c.DateTime(nullable: false),
                        CardHoulder = c.String(),
                        TrasactionStatus = c.String(),
                        PaymentDetails = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        Role_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                        DiscountVal = c.Double(nullable: false),
                        ProductDescription = c.String(),
                        ProductFamily_Id = c.Int(),
                        OrderProduct_Id = c.Int(),
                        ProductImage =  c.Byte(nullable: false)
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductFamily", t => t.ProductFamily_Id)
                .ForeignKey("dbo.OrderProduct", t => t.OrderProduct_Id)
                .Index(t => t.ProductFamily_Id)
                .Index(t => t.OrderProduct_Id);
            
            CreateTable(
                "dbo.ProductFamily",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamilyName = c.String(),
                        Specifications = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "OrderProduct_Id", "dbo.OrderProduct");
            DropForeignKey("dbo.OrderProduct", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.Product", "ProductFamily_Id", "dbo.ProductFamily");
            DropForeignKey("dbo.UserRole", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserRole", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.Order", "User_Id", "dbo.User");
            DropForeignKey("dbo.Order", "Payment_Id", "dbo.Payment");
            DropForeignKey("dbo.OrderProduct", "Order_Id", "dbo.Order");
            DropIndex("dbo.Product", new[] { "OrderProduct_Id" });
            DropIndex("dbo.Product", new[] { "ProductFamily_Id" });
            DropIndex("dbo.UserRole", new[] { "User_Id" });
            DropIndex("dbo.UserRole", new[] { "Role_Id" });
            DropIndex("dbo.Order", new[] { "User_Id" });
            DropIndex("dbo.Order", new[] { "Payment_Id" });
            DropIndex("dbo.OrderProduct", new[] { "Product_Id" });
            DropIndex("dbo.OrderProduct", new[] { "Order_Id" });
            DropTable("dbo.ProductFamily");
            DropTable("dbo.Product");
            DropTable("dbo.Role");
            DropTable("dbo.UserRole");
            DropTable("dbo.User");
            DropTable("dbo.Payment");
            DropTable("dbo.Order");
            DropTable("dbo.OrderProduct");
        }
    }
}
