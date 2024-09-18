
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models
#pragma warning restore IDE0130 // Namespace does not match folder structure
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