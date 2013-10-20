namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial34 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Course", "Description");
        }
    }
}
