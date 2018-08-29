namespace eWolfCodeBlogger.Helpers
{
    public static class HTMLFormater
    {
        public static string AddTitle(string raw)
        {
            return $"<h1>{raw}</h1>";
        }

        public static string AddCode(string text)
        {
            return $"<h4>{text}</h4>";
        }

        public static string LineBreak()
        {
            return "</br>";
        }

        internal static string Paragraph(string text)
        {
            return $"<p>{text}</p>";
        }

        internal static string ListItem(string text)
        {
            return $"<li>{text}</li>";
        }
    }
}
