using AwesomeBookingSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Domain.Entities
{
  public class Customer : AuditableEntity
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalID { get; set; }
    public DateTime DOB { get; set; }
    public ICollection<Luggage> Luggages { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
  }
}
