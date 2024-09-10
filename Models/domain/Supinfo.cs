
namespace PlantOpedia.Models.Domain
{

    public class Supinfo
    {
        public int Id { get; set; }

        public string PlantId { get; set; } = null!;

        public string? TaxRank { get; set; }

        public string? TaxonStatus { get; set; }

        public string? Family { get; set; }

        public string? GenusHybrid { get; set; }

        public string? Genus { get; set; }

        public string? SpeciesHybrid { get; set; }

        public string? GeoArea { get; set; }

        public string? Climate { get; set; }
    }
}