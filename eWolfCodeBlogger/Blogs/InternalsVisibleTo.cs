using eWolfCodeBlogger.Extensions;
using eWolfCodeBlogger.Interfaces;
using System.Text;

namespace eWolfCodeBlogger.Blogs
{
    public class InternalsVisibleTo : IBuildPage
    {
        private StringBuilder _rawText = new StringBuilder();

        public string Tags
        {
            get
            {
                return "UnitTest;InternalsVisibleTo";
            }
        }

        public void BuildPage()
        {
            // _rawText.Append(HTMLFormater.AddTitle("InternalsVisibleTo"));
            _rawText.AddTitle("Internals Visible To");

            _rawText.LineBreak();

            _rawText.Paragraph($"When we start unit testing code, you alwas find private methods you would like to test." +
                $"We don't want to break out encapsulation, so the next best thing is to us internal and add the InternalsVisableTo in the AssemblyInfo file.");

            _rawText.LineBreak();
            _rawText.AddCode("[assembly: InternalsVisibleTo('MyProjectInitTests')]");
            _rawText.LineBreak();

            // _rawText.Append()
        }
    }
}
