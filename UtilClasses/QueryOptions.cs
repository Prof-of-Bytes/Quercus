using System.Linq.Expressions;

namespace Quercus.Utils{

    public class QueryOptions<T>{

        public Expression<Func<T, Object>> OrderBy {get; set;} = null!;
        public Expression<Func<T, Object>> Where {get; set;} = null!;

        public string OrderByDirection {get; set;} = "asc"; //default value

        public int PageNumber {get; set;}
        public int PageSize {get; set;}

        private string[] _includes = Array.Empty<string>();

        public string Includes { set => _includes = value.Replace(" ", "").Split(',');}

        public string[] GetIncludes() => _includes;

        public bool HasWhere => Where != null;
        public bool HasOrderBy => OrderBy != null;

        public bool HasPaging => PageNumber > 0 && PageSize > 0;

    }


}