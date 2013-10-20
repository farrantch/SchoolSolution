namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial33 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbreviation = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Department");
        }
    }
}
