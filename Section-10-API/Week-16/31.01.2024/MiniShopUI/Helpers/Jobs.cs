using System.Formats.Tar;

namespace MiniShop.MVC.Helpers
{
    public static class Jobs
    {
        public static string GetUrl(string text)
        {
            if (string.IsNullOrEmpty(text)) return null;
            text = text.Trim();
            text = text.Replace("İ", "i");
            text = text.Replace("I", "ı");
            text = text.Replace("ı", "ı");

            text = text.ToLower();
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ç", "c");
            text = text.Replace("ğ", "g");


            text = text.Replace("\"", "");
            text = text.Replace("'", "");
            text = text.Replace("^", "");
            text = text.Replace("#", "");
            text = text.Replace("+", "");
            text = text.Replace("$", "");
            text = text.Replace("%", "");
            text = text.Replace("½", "");
            text = text.Replace("&", "");
            text = text.Replace("/", "");
            text = text.Replace("{", "");
            text = text.Replace("}", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("[", "");
            text = text.Replace("]", "");
            text = text.Replace("=", "");
            text = text.Replace("_", "");
            text = text.Replace("?", "");
            text = text.Replace("*", "");
            text = text.Replace("<", "");
            text = text.Replace(">", "");
            text = text.Replace("`", "");
            text = text.Replace("~", "");
            text = text.Replace("|", "");
            text = text.Replace(",", "");
            text = text.Replace(".", "");
            text = text.Replace(":", "");
            text = text.Replace("¨", "");
            text = text.Replace("€", "");
            text = text.Replace("@", "");
            text = text.Replace("ß", "");
            text = text.Replace("!", "");
            text = text.Replace(";", "");

            string[] splitResult = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            text = String.Join('-', splitResult);

            return text;
        }
    }
}
