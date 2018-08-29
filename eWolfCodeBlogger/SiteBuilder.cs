using eWolfCodeBlogger.Blogs;
using eWolfCodeBlogger.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace eWolfCodeBlogger
{
    public class SiteBuilder
    {
        private List<IBuildPage> CreateListOfPages()
        {
            List<IBuildPage> pages = new List<IBuildPage>
            {
                new Extension(),
                new InternalsVisibleTo(),
                new UnitTestStructure(),
            };

            return pages;
        }

        public string GetOutputPath()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string path = Path.GetDirectoryName(exePath);


            DirectoryInfo parentDir = Directory.GetParent(path);
            parentDir = Directory.GetParent(parentDir.FullName);


            return parentDir.FullName + "/Output/Blogs";
        }

        public void Build()
        {
            string path = GetOutputPath();
            Directory.CreateDirectory(path);

            foreach (IBuildPage bp in CreateListOfPages())
            {
                bp.BuildPage();
                string rawHtml = bp.Output();

                File.WriteAllText(Path.Combine(path, bp.Name + ".html"), rawHtml);
            }
        }
    }
}
