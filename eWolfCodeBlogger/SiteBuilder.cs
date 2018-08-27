using eWolfCodeBlogger.Blogs;
using eWolfCodeBlogger.Interfaces;
using System.Collections.Generic;

namespace eWolfCodeBlogger
{
    public class SiteBuilder
    {
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
            foreach (IBuildPage bp in CreateListOfPages())
            {
                bp.BuildPage();
                string rawHtml = bp.Output();
            }
        }
    }
}
