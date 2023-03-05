namespace Electrodevices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Electrodevices", "Model", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Electrodevices", "Model");
        }
    }
}
