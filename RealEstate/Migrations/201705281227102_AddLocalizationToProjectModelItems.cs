namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocalizationToProjectModelItems : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Year", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Year", c => c.String(nullable: false));
        }
    }
}
