using System.Linq.Expressions;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Utils{
#pragma warning restore IDE0130 // Namespace does not match folder structure

    public class QueryOptions<T>{

        public Expression<Func<T, Object>> OrderBy {get; set;} = null!;
        public Expression<Func<T, bool>> Where {get; set;} = null!;

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

    public static class QueryExtensions{

        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int pagenum, int pagesize)
        {
            return query.Skip((pagenum -1 ) * pagesize).Take(pagesize);
        }
    }


}