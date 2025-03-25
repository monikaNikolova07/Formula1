using System;
using System.Collections.Generic;

namespace Formula1.Data.Models;

public partial class Driver
{
    public int DriverId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public string Nationality { get; set; } = null!;

    public int? TeamId { get; set; }

    public virtual ICollection<RaceResult> RaceResults { get; set; } = new List<RaceResult>();

    public virtual Team? Team { get; set; }
}
