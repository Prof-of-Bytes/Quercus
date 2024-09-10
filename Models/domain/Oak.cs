

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlantOpedia.Models.Domain
{

    [PrimaryKey("PlantId")]
    public class Oak
    {

        [Column("plant_id")]
        public string PlantId { get; set; } = null!;

        [Column("ipni_id")]
        public string? IpniId { get; set; }

        [Column("species")]
        public string? Species { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("taxon_name")]
        public string? TaxonName { get; set; }
    }
}