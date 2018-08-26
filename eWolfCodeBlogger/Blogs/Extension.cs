using eWolfCodeBlogger.Helpers;
using eWolfCodeBlogger.Interfaces;
using System.Text;

namespace eWolfCodeBlogger.Blogs
{
    public class Extension : IBuildPage
    {
        private StringBuilder _rawText = new StringBuilder();

        public string Tags
        {
            get
            {
                return "Extension";
            }
        }

        public void BuildPage()
        {
            _rawText.Append(HTMLFormater.AddTitle("Extenstions"));
        }
    }
}
