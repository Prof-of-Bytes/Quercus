#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models{
#pragma warning restore IDE0130 // Namespace does not match folder structure

    public static class Nav{
        public static string Active(string value, string current) => (value == current) ? "active" :"";
        public static string Active(int value, int current) => (value == current) ? "active" : "";
    }

}