namespace FlorariaPOCData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datimenotmandatory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Order", "OrderDate", c => c.DateTime());
            AlterColumn("dbo.User", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Birthdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Order", "OrderDate", c => c.DateTime(nullable: false));
        }
    }
}
