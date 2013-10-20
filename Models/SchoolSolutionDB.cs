﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;


namespace SchoolSolution.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<LibraryItem> LibraryItems { get; set; }

        public DbSet<Settings> Settings { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<CheckoutLibraryItemTicket> CheckoutLibaryItemTickets { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<CheckoutEquipmentTicket> CheckoutEquipmentTickets { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<CheckoutAreaTicket> CheckoutAreaTickets { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTicket> CourseHistoryTickets { get; set; }
    }
}