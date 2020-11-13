using System;
namespace Project.Web
{
    public static class DOM
    {
        private static readonly String P = "p";

        public static String GetParagraph(this String p_string)
        {
            if (String.IsNullOrEmpty(p_string)) throw new ArgumentNullException();
            return CreateElement(P, p_string);
        }

        private static String CreateElement(String p_tag, String p_string)
        {
            return $"<{p_tag}>{p_string}</{p_tag}>";
        }
    }
}
