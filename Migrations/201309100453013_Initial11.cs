namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProfileUserProfiles", "UserProfile_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.UserProfileUserProfiles", "UserProfile_UserId1", "dbo.UserProfile");
            DropIndex("dbo.UserProfileUserProfiles", new[] { "UserProfile_UserId" });
            DropIndex("dbo.UserProfileUserProfiles", new[] { "UserProfile_UserId1" });
            CreateTable(
                "dbo.Guardian",
                c => new
                    {
                        GuardianId = c.Int(nullable: false, identity: true),
                        PrimaryContact = c.Boolean(nullable: false),
                        RelationshipIdSelector = c.String(),
                        UserProfile_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.GuardianId)
                .ForeignKey("dbo.UserProfile", t => t.UserProfile_UserId)
                .Index(t => t.UserProfile_UserId);
            
            AddColumn("dbo.UserProfile", "Gender", c => c.String());
            AddColumn("dbo.UserProfile", "Country", c => c.String());
            AddColumn("dbo.UserProfile", "StateProvince", c => c.String());
            AddColumn("dbo.UserProfile", "BusRider", c => c.Boolean(nullable: false));
            AddColumn("dbo.UserProfile", "Photo", c => c.Binary());
            AddColumn("dbo.UserProfile", "UserProfile_UserId", c => c.Int());
            AddForeignKey("dbo.UserProfile", "UserProfile_UserId", "dbo.UserProfile", "UserId");
            CreateIndex("dbo.UserProfile", "UserProfile_UserId");
            DropColumn("dbo.UserProfile", "GenderIdSelected");
            DropColumn("dbo.UserProfile", "CountryIdSelected");
            DropColumn("dbo.UserProfile", "StateProvinceIdSelected");
            DropTable("dbo.UserProfileUserProfiles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserProfileUserProfiles",
                c => new
                    {
                        UserProfile_UserId = c.Int(nullable: false),
                        UserProfile_UserId1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserProfile_UserId, t.UserProfile_UserId1 });
            
            AddColumn("dbo.UserProfile", "StateProvinceIdSelected", c => c.String());
            AddColumn("dbo.UserProfile", "CountryIdSelected", c => c.String());
            AddColumn("dbo.UserProfile", "GenderIdSelected", c => c.String());
            DropIndex("dbo.Guardian", new[] { "UserProfile_UserId" });
            DropIndex("dbo.UserProfile", new[] { "UserProfile_UserId" });
            DropForeignKey("dbo.Guardian", "UserProfile_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.UserProfile", "UserProfile_UserId", "dbo.UserProfile");
            DropColumn("dbo.UserProfile", "UserProfile_UserId");
            DropColumn("dbo.UserProfile", "Photo");
            DropColumn("dbo.UserProfile", "BusRider");
            DropColumn("dbo.UserProfile", "StateProvince");
            DropColumn("dbo.UserProfile", "Country");
            DropColumn("dbo.UserProfile", "Gender");
            DropTable("dbo.Guardian");
            CreateIndex("dbo.UserProfileUserProfiles", "UserProfile_UserId1");
            CreateIndex("dbo.UserProfileUserProfiles", "UserProfile_UserId");
            AddForeignKey("dbo.UserProfileUserProfiles", "UserProfile_UserId1", "dbo.UserProfile", "UserId");
            AddForeignKey("dbo.UserProfileUserProfiles", "UserProfile_UserId", "dbo.UserProfile", "UserId");
        }
    }
}
