using eWolfCodeBlogger.Extensions;
using eWolfCodeBlogger.Interfaces;

namespace eWolfCodeBlogger.Blogs
{
    public class UnitTestStructure : BuildPageBase, IBuildPage
    {
        public string Name
        {
            get
            {
                return "UnitTestStructure";
            }
        }

        public string Tags
        {
            get
            {
                return "UnitTest;Set-up";
            }
        }

        public void BuildPage()
        {
            _rawText.AddTitle("Unit Tests Structure");

            _rawText.LineBreak();

            _rawText.Paragraph($"Unit test are just as important as the main production code. Care needs to be taken to have a structure to your unit tests.");

            using (var warpper = new HTMLUnorderedList(_rawText))
            {
                _rawText.ListItem($"Unit test should always be in a sepearte project.");
                _rawText.ListItem($"The project name should be the same as the main project with UnitTest suffifx. Like MyProjectUnitTests");
                _rawText.ListItem($"The folders with in the unit test project should match the main project.");
                _rawText.ListItem($"Each class should match the file name from the main project but with the suffix Tests");
            }

            _rawText.AddCode("public class PageBuilder");
            _rawText.Paragraph($"Will appear in the test project as...");

            _rawText.AddCode("public class PageBuilderTests");

            _rawText.LineBreak();

            _rawText.Paragraph($"The name of the unit test method should start with <strong>Should</strong> " +
                $"This allow you to easy see what methods are tests." +
                $"After the Should you need to have the action then the results. like");
            _rawText.AddCode("public void ShouldCreatePageWhenMissingName");
        }
    }
}
