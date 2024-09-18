#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models{
#pragma warning restore IDE0130 // Namespace does not match folder structure

    public class OakListViewModel{
        public IEnumerable<Oak> Oaks {get; set;} = new List<Oak>();
        public OakGridData CurrentRoute {get; set; } = new OakGridData();
        public int TotalPages {get; set;}
    }
}