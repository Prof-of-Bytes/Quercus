
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Quercus.Models
{

    [PrimaryKey("PlantId")]
    public class Oak
    {

        [Column("plant_id")]
        public string PlantId { get; set; } = null!;

        [Column("ipni_id")]
        public string? IpniId { get; set; }

        [Column("species")]
        public string? Species { get; set; } = string.Empty;

        [Column("description")]
        public string? Description { get; set; }

        [Column("taxon_name")]
        public string? TaxonName { get; set; }
    }
}