namespace Quercus.Models{

    public class OakListViewModel{
        public IEnumerable<Oak> Oaks {get; set;} = new List<Oak>();
        public OakGridData CurrentRoute {get; set; } = new OakGridData();
        public int TotalPages {get; set;}
    }
}