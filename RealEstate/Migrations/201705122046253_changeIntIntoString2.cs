namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeIntIntoString2 : DbMigration
    {
        public override void Up()
        {
           // AlterColumn("dbo.Projects", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
