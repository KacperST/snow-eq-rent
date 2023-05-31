using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentMVCApp.Models;

    public class ContextDb : DbContext
    {
        public ContextDb (DbContextOptions<ContextDb> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<RentMVCApp.Models.User> User { get; set; } = default!;
        public DbSet<RentMVCApp.Models.Item> Items { get; set; } = default!;
        public DbSet<RentMVCApp.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<RentMVCApp.Models.Company> Company { get; set; } = default!;
    }
