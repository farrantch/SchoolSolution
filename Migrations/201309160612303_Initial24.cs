namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial24 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingsId = c.Int(nullable: false, identity: true),
                        NumberOfTableResults = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SettingsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
        }
    }
}
