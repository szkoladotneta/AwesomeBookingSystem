using AwesomeBookingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Application.Common.Interfaces
{
    public interface IAwesomeDbContext
    {
        DbSet<Flight> Flights { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Customer> Customers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
