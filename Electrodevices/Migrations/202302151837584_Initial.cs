namespace Electrodevices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Electrodevice_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Electrodevices", t => t.Electrodevice_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Electrodevice_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Electrodevices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Wight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount_Stock = c.Int(nullable: false),
                        Amount_Defect = c.Int(nullable: false),
                        Amount_Sale = c.Int(nullable: false),
                        Category_ID = c.Int(),
                        Country_ID = c.Int(),
                        Date_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .ForeignKey("dbo.Dates", t => t.Date_Id)
                .Index(t => t.Category_ID)
                .Index(t => t.Country_ID)
                .Index(t => t.Date_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Baskets", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Baskets", "Electrodevice_Id", "dbo.Electrodevices");
            DropForeignKey("dbo.Electrodevices", "Date_Id", "dbo.Dates");
            DropForeignKey("dbo.Electrodevices", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Electrodevices", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Electrodevices", new[] { "Date_Id" });
            DropIndex("dbo.Electrodevices", new[] { "Country_ID" });
            DropIndex("dbo.Electrodevices", new[] { "Category_ID" });
            DropIndex("dbo.Baskets", new[] { "User_Id" });
            DropIndex("dbo.Baskets", new[] { "Electrodevice_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Dates");
            DropTable("dbo.Countries");
            DropTable("dbo.Categories");
            DropTable("dbo.Electrodevices");
            DropTable("dbo.Baskets");
            DropTable("dbo.Administrators");
        }
    }
}
