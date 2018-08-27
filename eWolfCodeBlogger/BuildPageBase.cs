using System.Text;

namespace eWolfCodeBlogger
{
    public class BuildPageBase
    {
        protected StringBuilder _rawText = new StringBuilder();

        public string Output()
        {
            return _rawText.ToString();
        }
    }
}
