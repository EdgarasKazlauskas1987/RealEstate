namespace RealEstate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalProjectFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Title", c => c.String());
            AddColumn("dbo.Projects", "Address", c => c.String());
            AddColumn("dbo.Projects", "PlotArea", c => c.Int(nullable: false));
            AddColumn("dbo.Projects", "NumberOfFloors", c => c.Int(nullable: false));
            AddColumn("dbo.Projects", "NumberOfRooms", c => c.Int(nullable: false));
            AddColumn("dbo.Projects", "AdditionalFacilities", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "AdditionalFacilities");
            DropColumn("dbo.Projects", "NumberOfRooms");
            DropColumn("dbo.Projects", "NumberOfFloors");
            DropColumn("dbo.Projects", "PlotArea");
            DropColumn("dbo.Projects", "Address");
            DropColumn("dbo.Projects", "Title");
        }
    }
}
