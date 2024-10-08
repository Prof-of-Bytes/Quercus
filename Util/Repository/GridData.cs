using Quercus.Utils;
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Repos
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

    public abstract class GridData
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortDirection { get; set; } = "asc";
        public string SortField { get; set; } = string.Empty;
        public int GetTotalPages(int count) => (count + PageSize - 1) / PageSize;

        public void SetSortAndDirection(string newsortfield, GridData current)
        {

            SortField = newsortfield;

            if (current.SortField.EqualsNoCase(newsortfield) && current.SortDirection == "asc")
            {
                SortDirection = "desc";
            }
            else
            {
                SortDirection = "asc";
            }

        }
        public GridData Clone() => (GridData)MemberwiseClone();

        public virtual Dictionary<string, string> ToDictionary() => new Dictionary<string, string> {
            { nameof(PageNumber), PageNumber.ToString()},
            { nameof(PageSize), PageSize.ToString()},
            { nameof(SortField), SortField},
            { nameof(SortDirection), SortDirection},
        };


    }

}