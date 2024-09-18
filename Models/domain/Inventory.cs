using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class Inventory{
        
       
        public int ID {get; set;}

        public string OakId {get; set;} = string.Empty; //foreign key
        [NotMapped]
        public Oak Oak {get; set;} = null!;//nvaigation property

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EntryDate  {get; set;}

        [Column("warehouse_location", TypeName = "varchar(50)")]
        [Comment("Location of the plant")]
        public string Location {get; set;} = string.Empty;
        
        [DataType(DataType.ImageUrl)]
        [NotMapped]
        public string? ImgUrl {get; set;}


    }
}