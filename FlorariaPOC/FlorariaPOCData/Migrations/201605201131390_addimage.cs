namespace FlorariaPOCData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addimage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "ProductImage", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "ProductImage", c => c.Byte(nullable: false));
        }
    }
}
