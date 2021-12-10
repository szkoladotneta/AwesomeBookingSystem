using AwesomeBookingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Persistance.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ReservationCode).HasMaxLength(15).IsRequired();
            builder.Property(p => p.CustomerId).IsRequired();
            builder.Property(p => p.FlightId).IsRequired();
        }
    }
}
