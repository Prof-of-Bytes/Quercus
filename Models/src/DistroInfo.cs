using System;
using System.Collections.Generic;

namespace PlantOpedia.Models.Source;

public partial class DistroInfo
{
    public string? PlantLocalityId { get; set; }

    public string? PlantNameId { get; set; }

    public string? ContinentCodeL1 { get; set; }

    public string? Continent { get; set; }

    public string? RegionCodeL2 { get; set; }

    public string? Region { get; set; }

    public string? AreaCodeL3 { get; set; }

    public string? Area { get; set; }

    public string? Introduced { get; set; }

    public string? Extinct { get; set; }

    public string? LocationDoubtful { get; set; }
}
