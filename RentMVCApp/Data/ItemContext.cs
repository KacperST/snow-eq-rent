using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentMVCApp.Models;

namespace RentMVCApp.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext (DbContextOptions<ItemContext> options)
            : base(options)
        {
        }

        public DbSet<RentMVCApp.Models.Item> Item { get; set; } = default!;
        public DbSet<RentMVCApp.Models.User> User { get; set; } = default!;
        public DbSet<RentMVCApp.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<RentMVCApp.Models.Company> Company { get; set; } = default!;
    }
}
