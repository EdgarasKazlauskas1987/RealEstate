namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yearIntoString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Year", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Year", c => c.Int(nullable: false));
        }
    }
}
