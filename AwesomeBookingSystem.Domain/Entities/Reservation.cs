using AwesomeBookingSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Domain.Entities
{
    public class Reservation : AuditableEntity
    {
        public string ReservationCode { get; set; }
        public int CustomerId { get; set; }
        public int FlightId { get; set; }

        public Flight Flight { get; set; }
        public Customer Customer { get; set; }

    }
}
