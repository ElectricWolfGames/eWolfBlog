using eWolfCodeBlogger.Blogs;
using eWolfCodeBlogger.Interfaces;
using System.Collections.Generic;

namespace eWolfCodeBlogger
{
    public class SiteBuilder
    {
        private List<IBuildPage> CreateListOfPages()
        {
            List<IBuildPage> pages = new List<IBuildPage>();
            pages.Add(new Extension());
            pages.Add(new InternalsVisibleTo());

            return pages;
        }

        public void Build()
        {
            // loop through all the pages and create each one.
        }
    }
}
