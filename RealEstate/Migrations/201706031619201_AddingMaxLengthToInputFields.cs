namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMaxLengthToInputFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Title", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Projects", "Address", c => c.String(maxLength: 40));
            AlterColumn("dbo.Projects", "Year", c => c.String(maxLength: 10));
            AlterColumn("dbo.Projects", "AdditionalFacilities", c => c.String(maxLength: 500));
            AlterColumn("dbo.Projects", "AdditionalInformation", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "AdditionalInformation", c => c.String());
            AlterColumn("dbo.Projects", "AdditionalFacilities", c => c.String());
            AlterColumn("dbo.Projects", "Year", c => c.String());
            AlterColumn("dbo.Projects", "Address", c => c.String());
            AlterColumn("dbo.Projects", "Title", c => c.String(nullable: false));
        }
    }
}
