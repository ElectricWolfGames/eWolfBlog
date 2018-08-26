using eWolfCodeBlogger.Helpers;
using System.Text;

namespace eWolfCodeBlogger.Extensions
{
    public static class StringBuilderExtension
    {
        public static void AddTitle(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.AddTitle(text));
        }

        public static void AddCode(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.AddCode(text));
        }

        public static void LineBreak(this StringBuilder sb)
        {
            sb.AppendLine(HTMLFormater.LineBreak());
        }

        public static void Paragraph(this StringBuilder sb, string text)
        {
            sb.Append(HTMLFormater.Paragraph(text));
        }
    }
}
