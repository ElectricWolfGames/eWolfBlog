using eWolfCodeBlogger.Blogs;
using eWolfCodeBlogger.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace eWolfCodeBlogger
{
    public class SiteBuilder
    {
        private const string _outputPath = @"C:\GitHub\eWolfBlog\eWolfCodeBlogger\Output\Blogs";

        private List<IBuildPage> CreateListOfPages()
        {
            List<IBuildPage> pages = new List<IBuildPage>
            {
                new Extension(),
                new InternalsVisibleTo()
            };

            return pages;
        }

        public void Build()
        {
            Directory.CreateDirectory(_outputPath);

            foreach (IBuildPage bp in CreateListOfPages())
            {
                bp.BuildPage();
                string rawHtml = bp.Output();

                File.WriteAllText(Path.Combine(_outputPath, bp.Name + ".html"), rawHtml);
            }
        }
    }
}
