namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial25 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CheckoutLibraryTicket", "User_UserId", "dbo.UserProfile");
            DropForeignKey("dbo.CheckoutLibraryTicket", "Item_LibraryItemID", "dbo.LibraryItem");
            DropForeignKey("dbo.CheckoutEquipmentTicket", "Item_EquipmentId", "dbo.Equipment");
            DropIndex("dbo.CheckoutLibraryTicket", new[] { "User_UserId" });
            DropIndex("dbo.CheckoutLibraryTicket", new[] { "Item_LibraryItemID" });
            DropIndex("dbo.CheckoutEquipmentTicket", new[] { "Item_EquipmentId" });
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Degree",
                c => new
                    {
                        DegreeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.DegreeId);
            
            CreateTable(
                "dbo.Term",
                c => new
                    {
                        TermId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartingDate = c.DateTime(nullable: false),
                        EndingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TermId);
            
            AddColumn("dbo.CheckoutEquipmentTicket", "Due", c => c.DateTime(nullable: false));
            AddColumn("dbo.CheckoutEquipmentTicket", "Equipment_EquipmentId", c => c.Int());
            AddForeignKey("dbo.CheckoutEquipmentTicket", "Equipment_EquipmentId", "dbo.Equipment", "EquipmentId");
            CreateIndex("dbo.CheckoutEquipmentTicket", "Equipment_EquipmentId");
            DropColumn("dbo.CheckoutEquipmentTicket", "Item_EquipmentId");
            DropTable("dbo.CheckoutLibraryTicket");
            DropTable("dbo.LibraryItem");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LibraryItem",
                c => new
                    {
                        LibraryItemID = c.Int(nullable: false, identity: true),
                        DatePublished = c.DateTime(nullable: false),
                        Barcode = c.Int(nullable: false),
                        Description = c.String(),
                        Title = c.String(),
                        ISBN = c.String(),
                        DateAdded = c.DateTime(),
                        Publisher = c.String(),
                        MagazineName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.LibraryItemID);
            
            CreateTable(
                "dbo.CheckoutLibraryTicket",
                c => new
                    {
                        CheckoutLibraryTicketId = c.Int(nullable: false, identity: true),
                        CheckedOut = c.DateTime(nullable: false),
                        CheckedIn = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                        Item_LibraryItemID = c.Int(),
                    })
                .PrimaryKey(t => t.CheckoutLibraryTicketId);
            
            AddColumn("dbo.CheckoutEquipmentTicket", "Item_EquipmentId", c => c.Int());
            DropIndex("dbo.CheckoutEquipmentTicket", new[] { "Equipment_EquipmentId" });
            DropForeignKey("dbo.CheckoutEquipmentTicket", "Equipment_EquipmentId", "dbo.Equipment");
            DropColumn("dbo.CheckoutEquipmentTicket", "Equipment_EquipmentId");
            DropColumn("dbo.CheckoutEquipmentTicket", "Due");
            DropTable("dbo.Term");
            DropTable("dbo.Degree");
            DropTable("dbo.Course");
            CreateIndex("dbo.CheckoutEquipmentTicket", "Item_EquipmentId");
            CreateIndex("dbo.CheckoutLibraryTicket", "Item_LibraryItemID");
            CreateIndex("dbo.CheckoutLibraryTicket", "User_UserId");
            AddForeignKey("dbo.CheckoutEquipmentTicket", "Item_EquipmentId", "dbo.Equipment", "EquipmentId");
            AddForeignKey("dbo.CheckoutLibraryTicket", "Item_LibraryItemID", "dbo.LibraryItem", "LibraryItemID");
            AddForeignKey("dbo.CheckoutLibraryTicket", "User_UserId", "dbo.UserProfile", "UserId");
        }
    }
}
