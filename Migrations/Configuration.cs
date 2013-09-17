namespace SchoolSolution.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Mvc;
    using WebMatrix.WebData;
    using System.Web.Security;
    using SchoolSolution.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolSolution.Models.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolSolution.Models.UsersContext context)
        {

            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            }

            //DELETE ALL USERS
            foreach (var entity in context.UserProfiles)
            {
                string[] roles = Roles.GetRolesForUser(entity.UserName);

                foreach (var role in roles)
                    Roles.RemoveUserFromRole(entity.UserName, role);

                Membership.DeleteUser(entity.UserName);
            }

            //DELETE ALL ROLES
            string[] allRoles = Roles.GetAllRoles();
            foreach (string role in allRoles)
                Roles.DeleteRole(role);

            context.SaveChanges();

            //CREATE ROLES
            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");
            if (!Roles.RoleExists("Aid"))
                Roles.CreateRole("Aid");
            if (!Roles.RoleExists("BoardMember"))
                Roles.CreateRole("BoardMember");
            if (!Roles.RoleExists("Cafeteria"))
                Roles.CreateRole("Cafeteria");
            if (!Roles.RoleExists("Coach"))
                Roles.CreateRole("Coach");
            if (!Roles.RoleExists("CommunityMember"))
                Roles.CreateRole("CommunityMember");
            if (!Roles.RoleExists("Counselor"))
                Roles.CreateRole("Counselor");
            if (!Roles.RoleExists("Custodian"))
                Roles.CreateRole("Custodian");
            if (!Roles.RoleExists("Donor"))
                Roles.CreateRole("Donor");
            if (!Roles.RoleExists("Graduate"))
                Roles.CreateRole("Graduate");
            if (!Roles.RoleExists("Guardian"))
                Roles.CreateRole("Guardian");
            if (!Roles.RoleExists("Librarian"))
                Roles.CreateRole("Librarian");
            if (!Roles.RoleExists("Mentor"))
                Roles.CreateRole("Mentor");
            if (!Roles.RoleExists("PowerUser"))
                Roles.CreateRole("PowerUser");
            if (!Roles.RoleExists("Principal"))
                Roles.CreateRole("Principal");
            if (!Roles.RoleExists("Secretary"))
                Roles.CreateRole("Secretary");
            if (!Roles.RoleExists("Security"))
                Roles.CreateRole("Security");
            if (!Roles.RoleExists("SpecialServices"))
                Roles.CreateRole("SpecialServices");
            if (!Roles.RoleExists("Student"))
                Roles.CreateRole("Student");
            if (!Roles.RoleExists("Student-Locked"))
                Roles.CreateRole("Student-Locked");
            if (!Roles.RoleExists("Superintendent"))
                Roles.CreateRole("Superintendent");
            if (!Roles.RoleExists("Teacher"))
                Roles.CreateRole("Teacher");
            if (!Roles.RoleExists("User"))
                Roles.CreateRole("User");
            if (!Roles.RoleExists("Volunteer"))
                Roles.CreateRole("Volunteer");
           

            //CREATE EXAMPLE USERS

            if (!WebSecurity.UserExists("admin"))
                WebSecurity.CreateUserAndAccount("admin", "admin", false);

            if (!WebSecurity.UserExists("farrantc"))
                WebSecurity.CreateUserAndAccount("farrantc", "farrantc", new
            {
                FirstName = "Chase",
                MiddleName = "Michael",
                LastName = "Farrant",
                Email = "farrantc@ksu.edu",
                Gender = "Male",
                BirthDate = new DateTime(1990, 11, 4),
                Address = "1800 Platt St.",
                ApartmentNumber = 12,
                ZipCode = "66502",
                Country = "US",
                StateProvince = "Kansas",
                LastActivityOn = DateTime.Now,
                AccountCreatedOn = DateTime.Now,
                PasswordChangedOn = DateTime.Now,
                Balance = 23.00,
                Disabled = false,
                Verified = true,
                DisableLibraryCheckout = false,
                DisableAreaCheckout = false,
                DisableEquipmentCheckout = false,
                Graduate = false,
                SubsidizedLunch = false,
                BusRider = false,
                SSN = "234-38-2323",
                Grade = "11"
            }, false);

            if (!WebSecurity.UserExists("meyern"))
                WebSecurity.CreateUserAndAccount("meyern", "meyern", new
                {
                    FirstName = "Nick",
                    MiddleName = "Josesph",
                    LastName = "Meyer",
                    Email = "meyern@ksu.edu",
                    Gender = "Male",
                    BirthDate = new DateTime(1991, 1, 15),
                    Address = "300 Main St.",
                    ApartmentNumber = 2,
                    ZipCode = "63532",
                    Country = "US",
                    StateProvince = "Kansas",
                    LastActivityOn = DateTime.Now,
                    AccountCreatedOn = DateTime.Now,
                    PasswordChangedOn = DateTime.Now,
                    Balance = 171.00,
                    Disabled = false,
                    Verified = true,
                    DisableLibraryCheckout = false,
                    DisableAreaCheckout = false,
                    DisableEquipmentCheckout = false,
                    Graduate = false,
                    SubsidizedLunch = false,
                    BusRider = false,
                    SSN = "524-52-7244",
                    Grade = "5"
                }, false);

            if (!WebSecurity.UserExists("narva"))
                WebSecurity.CreateUserAndAccount("narva", "narva", new
                {
                    FirstName = "Austin",
                    MiddleName = "Josesph",
                    LastName = "Narverud",
                    Email = "narva@ksu.edu",
                    Gender = "Male",
                    BirthDate = new DateTime(1990, 12, 31),
                    Address = "9041 Helm",
                    ZipCode = "64562",
                    Country = "US",
                    StateProvince = "Missouri",
                    LastActivityOn = DateTime.Now,
                    AccountCreatedOn = DateTime.Now,
                    PasswordChangedOn = DateTime.Now,
                    Balance = 1.00,
                    Disabled = false,
                    Verified = true,
                    DisableLibraryCheckout = true,
                    DisableAreaCheckout = true,
                    DisableEquipmentCheckout = true,
                    Graduate = false,
                    SubsidizedLunch = true,
                    BusRider = true,
                    SSN = "133-52-5673",
                    Grade = "3"
                }, false);

            if (!WebSecurity.UserExists("testuser"))
                WebSecurity.CreateUserAndAccount("testuser", "testuser", new
                {
                    FirstName = "Testing",
                    MiddleName = "Howard",
                    LastName = "Rodguieze",
                    Email = "testing@ksu.edu",
                    Gender = "Female",
                    BirthDate = new DateTime(1992, 2, 11),
                    Address = "9041 Helm",
                    ZipCode = "64562",
                    Country = "United Kingdom",
                    StateProvince = "Britian",
                    LastActivityOn = DateTime.Now,
                    AccountCreatedOn = DateTime.Now,
                    PasswordChangedOn = DateTime.Now,
                    Balance = 1.00,
                    Disabled = false,
                    Verified = true,
                    DisableLibraryCheckout = true,
                    DisableAreaCheckout = true,
                    DisableEquipmentCheckout = true,
                    Graduate = false,
                    SubsidizedLunch = true,
                    BusRider = true,
                    SSN = "232-12-2343",
                    Grade = "5"
                }, false);

            ////ADD USERS TO ROLLS
            if (!Roles.GetRolesForUser("farrantc").Contains("User"))
                Roles.AddUsersToRoles(new[] { "farrantc" }, new[] { "User" });

            if (!Roles.GetRolesForUser("meyern").Contains("User"))
                Roles.AddUsersToRoles(new[] { "meyern" }, new[] { "User" });

            if (!Roles.GetRolesForUser("narva").Contains("User"))
                Roles.AddUsersToRoles(new[] { "narva" }, new[] { "User" });

            if (!Roles.GetRolesForUser("testuser").Contains("User"))
                Roles.AddUsersToRoles(new[] { "testuser" }, new[] { "User" });

            if (!Roles.GetRolesForUser("admin").Contains("Administrator"))
                Roles.AddUsersToRoles(new[] { "admin" }, new[] { "Administrator" });

            context.SaveChanges();

            //REMOVE LIBRARY ITEMS
            foreach (LibraryItem li in context.LibraryItems)
                context.LibraryItems.Remove(li);

            context.SaveChanges();

            //ADD LIBRARY ITEMS
            context.LibraryItems.Add(new Book
            {
                DatePublished = DateTime.Now,
                Barcode = 934940,
                Description = "This is a description of a demo book.",
                Title = "How to Kill a Mockingbird",
                ISBN = "0-85131-041-9",
                DateAdded = DateTime.Now,
                Authors = new string[] { "R.J. Welling", "Author Test2" },
                Publisher = "Scribner"
            });

            //CONFIGURE SETTINGS


            context.SaveChanges();
        }
    }
}
