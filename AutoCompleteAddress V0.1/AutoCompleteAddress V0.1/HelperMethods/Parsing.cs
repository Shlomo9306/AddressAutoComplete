
namespace AutoCompleteAddress.HelperMethods
{
    public static class Parsing
    {
        /// <summary>
        /// TryParsing Nullaable Int
        /// </summary>
        /// <param name="string to parse"></param>
        /// <returns></returns>
        public static int? TryParseNullable(string stringToParse)
        {
            int outValue;
            return int.TryParse(stringToParse, out outValue) ? (int?)outValue : null;
        }
    }
}
