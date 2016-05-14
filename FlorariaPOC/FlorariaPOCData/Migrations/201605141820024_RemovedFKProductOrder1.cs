namespace FlorariaPOCData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedFKProductOrder1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "OrderProduct_Id", "dbo.OrderProduct");
            DropIndex("dbo.Product", new[] { "OrderProduct_Id" });
            DropColumn("dbo.Product", "OrderProduct_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "OrderProduct_Id", c => c.Int());
            CreateIndex("dbo.Product", "OrderProduct_Id");
            AddForeignKey("dbo.Product", "OrderProduct_Id", "dbo.OrderProduct", "Id");
        }
    }
}
