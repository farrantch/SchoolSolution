namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        UserProfile_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.EquipmentId)
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_UserId)
                .Index(t => t.UserProfile_UserId);
            
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        AreaId = c.Int(nullable: false, identity: true),
                        UserProfile_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.AreaId)
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_UserId)
                .Index(t => t.UserProfile_UserId);
            
            CreateTable(
                "dbo.UserProfileUserProfiles",
                c => new
                    {
                        UserProfile_UserId = c.Int(nullable: false),
                        UserProfile_UserId1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserProfile_UserId, t.UserProfile_UserId1 })
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_UserId)
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_UserId1)
                .Index(t => t.UserProfile_UserId)
                .Index(t => t.UserProfile_UserId1);
            
            AddColumn("dbo.UserProfile", "DisableLibraryCheckout", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "DisableAreaCheckout", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "DisableEquipmentCheckout", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "HaveGraduated", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "SubsidizedLunch", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "SSN", c => c.String());
            AddColumn("dbo.UserProfile", "Grade", c => c.String());
            AddColumn("dbo.LibraryItem", "UserProfile_UserId", c => c.Int());
            AlterColumn("dbo.UserProfile", "UserName", c => c.String());
            AddForeignKey("dbo.LibraryItem", "UserProfile_UserId", "dbo.UserProfile", "UserId");
            CreateIndex("dbo.LibraryItem", "UserProfile_UserId");
            DropColumn("dbo.UserProfile", "FirstName");
            DropColumn("dbo.UserProfile", "MiddleName");
            DropColumn("dbo.UserProfile", "LastName");
            DropColumn("dbo.UserProfile", "Address");
            DropColumn("dbo.UserProfile", "ApartmentNumber");
            DropColumn("dbo.UserProfile", "ZipCode");
            DropColumn("dbo.UserProfile", "ZipCodeExtension");
            DropColumn("dbo.UserProfile", "Discriminator");
            DropColumn("dbo.LibraryItem", "Title");
            DropColumn("dbo.LibraryItem", "Title1");
            DropColumn("dbo.LibraryItem", "Title2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LibraryItem", "Title2", c => c.String());
            AddColumn("dbo.LibraryItem", "Title1", c => c.String());
            AddColumn("dbo.LibraryItem", "Title", c => c.String());
            AddColumn("dbo.UserProfile", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.UserProfile", "ZipCodeExtension", c => c.Int());
            AddColumn("dbo.UserProfile", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfile", "ApartmentNumber", c => c.Int());
            AddColumn("dbo.UserProfile", "Address", c => c.String(nullable: false, maxLength: 24));
            AddColumn("dbo.UserProfile", "LastName", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.UserProfile", "MiddleName", c => c.String(nullable: false, maxLength: 21));
            AddColumn("dbo.UserProfile", "FirstName", c => c.String(nullable: false, maxLength: 21));
            DropIndex("dbo.UserProfileUserProfiles", new[] { "UserProfile_UserId1" });
            DropIndex("dbo.UserProfileUserProfiles", new[] { "UserProfile_UserId" });
            DropIndex("dbo.Area", new[] { "UserProfile_UserId" });
            DropIndex("dbo.Equipment", new[] { "UserProfile_UserId" });
            DropIndex("dbo.LibraryItem", new[] { "UserProfile_UserId" });
            DropForeignKey("dbo.UserProfileUserProfiles", "UserProfile_UserId1", "dbo.UserProfile");
            DropForeignKey("dbo.UserProfileUserProfiles", "UserProfile_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Area", "UserProfile_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Equipment", "UserProfile_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.LibraryItem", "UserProfile_UserId", "dbo.UserProfile");
            AlterColumn("dbo.UserProfile", "UserName", c => c.String(nullable: false, maxLength: 21));
            DropColumn("dbo.LibraryItem", "UserProfile_UserId");
            DropColumn("dbo.UserProfile", "Grade");
            DropColumn("dbo.UserProfile", "SSN");
            DropColumn("dbo.UserProfile", "SubsidizedLunch");
            DropColumn("dbo.UserProfile", "HaveGraduated");
            DropColumn("dbo.UserProfile", "DisableEquipmentCheckout");
            DropColumn("dbo.UserProfile", "DisableAreaCheckout");
            DropColumn("dbo.UserProfile", "DisableLibraryCheckout");
            DropTable("dbo.UserProfileUserProfiles");
            DropTable("dbo.Area");
            DropTable("dbo.Equipment");
        }
    }
}
