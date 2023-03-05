namespace Electrodevices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPath_Picture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Electrodevices", "Path_Picture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Electrodevices", "Path_Picture");
        }
    }
}
