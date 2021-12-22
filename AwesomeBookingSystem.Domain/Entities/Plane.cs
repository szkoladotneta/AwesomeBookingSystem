using AwesomeBookingSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeBookingSystem.Domain.Entities;
public class Plane : AuditableEntity
{
  public string Name { get; set; }
  public string Type { get; set; }
  public int EconomicSeats { get; set; }
  public int BiznesSeats { get; set; }
  public bool TransportAnimals { get; set; }
  public Luggage MaxLuggage { get; set; }

public Plane(int foo){}
}

