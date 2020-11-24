using System;
namespace Project.Web
{
    public static class DOM
    {

        public static String GetParagraph(this String p_string)
        {
            if (String.IsNullOrEmpty(p_string)) throw new ArgumentNullException();
            return CreateElement("p", p_string);
        }

        private static String CreateElement(String p_tag, String p_string)
        {
            return $"<{p_tag}>{p_string}</{p_tag}>";
        }

        public static String GetTitle(this String p_string, byte p_taille)
        {
            if (String.IsNullOrEmpty(p_string)) throw new ArgumentNullException();
            return CreateElement($"h{p_taille}", p_string);
        }
    }
}
