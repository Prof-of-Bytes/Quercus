using System.Text;

namespace Quercus.Utils
{

    public static class StringExt
    {

        public static string Slug(this string str)
        {
            //string builder helper
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (!char.IsPunctuation(c) || c == '-')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Replace(' ', '-').ToLower();
        }
        //sets to lower and compares
        public static bool EqualsNoCase(this string str, string tocompare) => str?.ToLower() == tocompare?.ToLower();

        public static int ToInt(this string str)
        {
            int.TryParse(str, out int value);
            return value;
        }

        public static string Cap(this string str)
        {
            return str?[..1]?.ToUpper() + str?.Substring(1).ToLower();
        }


    }



}