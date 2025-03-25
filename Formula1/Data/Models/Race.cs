using System;
using System.Collections.Generic;

namespace Formula1.Data.Models;

public partial class Race
{
    public int RaceId { get; set; }

    public string RaceName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateOnly RaceDate { get; set; }

    public int SeasonYear { get; set; }

    public virtual ICollection<RaceResult> RaceResults { get; set; } = new List<RaceResult>();
}
