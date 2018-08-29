using eWolfCodeBlogger.Helpers;
using System.Text;

namespace eWolfCodeBlogger.Extensions
{
    public static class StringBuilderExtension
    {
        public static void AddCode(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.AddCode(text));
        }

        public static void AddTitle(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.AddTitle(text));
        }

        public static void LineBreak(this StringBuilder sb)
        {
            sb.AppendLine(HTMLFormater.LineBreak());
        }

        public static void ListItem(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.ListItem(text));
        }

        public static void Paragraph(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.Paragraph(text));

        }

        public static void Href(this StringBuilder sb, string text, string name)
        {
            sb.Append(HTMLFormater.Href(text, name));
        }
    }
}
