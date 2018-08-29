using System;
using System.Text;

namespace eWolfCodeBlogger.Blogs
{
    public class HTMLUnorderedList : IDisposable
    {
        private readonly StringBuilder _rawText;

        public HTMLUnorderedList(StringBuilder rawText)
        {
            _rawText = rawText;
            _rawText.Append("<ul>");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _rawText.Append("</ul>");
            }
        }
    }
}
