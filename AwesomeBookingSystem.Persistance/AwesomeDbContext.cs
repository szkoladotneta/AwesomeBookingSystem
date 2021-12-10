using AwesomeBookingSystem.Application.Common.Interfaces;
using AwesomeBookingSystem.Domain.Common;
using AwesomeBookingSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Persistance
{
    public class AwesomeDbContext : IdentityDbContext, IAwesomeDbContext
    {
        public AwesomeDbContext(DbContextOptions<AwesomeDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken token = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateId = "";
                        entry.Entity.CreateDate = DateTime.Now;
                        entry.Entity.IsActive = true;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifyId = "";
                        entry.Entity.ModifyDate = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifyId = "";
                        entry.Entity.ModifyDate = DateTime.Now;
                        entry.Entity.InactivateDate = DateTime.Now;
                        entry.Entity.InactivateId = "";
                        entry.Entity.IsActive = false;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(token);
        }
    }
}
