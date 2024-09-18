using System.Text.Json.Serialization;
using Quercus.Repos;
using Quercus.Utils;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models
#pragma warning restore IDE0130 // Namespace does not match folder structure
{

    public class OakGridData : GridData
    {

        public OakGridData() => SortField = nameof(Oak.Species);

        [JsonIgnore]
        public bool IsSortBySpecies => SortField.EqualsNoCase(nameof(Oak.Species));
    }
}