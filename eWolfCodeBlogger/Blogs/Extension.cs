using eWolfCodeBlogger.Helpers;
using eWolfCodeBlogger.Interfaces;

namespace eWolfCodeBlogger.Blogs
{
    public class Extension : BuildPageBase, IBuildPage
    {
        public string Name
        {
            get
            {
                return "Extension";
            }
        }

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
