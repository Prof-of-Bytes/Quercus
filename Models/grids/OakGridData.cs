using System.Text.Json.Serialization;
using Quercus.Repos;
using Quercus.Utils;

namespace Quercus.Models
{

    public class OakGridData : GridData
    {

        public OakGridData() => SortField = nameof(Oak.Species);

        [JsonIgnore]
        public bool IsSortBySpecies => SortField.EqualsNoCase(nameof(Oak.Species));
    }
}