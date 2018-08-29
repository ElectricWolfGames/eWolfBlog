using eWolfCodeBlogger.Blogs;
using eWolfCodeBlogger.Extensions;
using eWolfCodeBlogger.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eWolfCodeBlogger
{
    public class SiteBuilder
    {
        public void Build()
        {
            string path = GetOutputPath();
            Directory.CreateDirectory(path);

            string header = CreateHeader();

            foreach (IBuildPage bp in CreateListOfPages())
            {

                bp.BuildPage();

                string rawHtml = header;
                rawHtml += bp.Output();

                File.WriteAllText(Path.Combine(path, bp.Name + ".html"), rawHtml);
            }
        }

        public string GetOutputPath()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string path = Path.GetDirectoryName(exePath);


            DirectoryInfo parentDir = Directory.GetParent(path);
            parentDir = Directory.GetParent(parentDir.FullName);


            return parentDir.FullName + "/Output/Blogs";
        }

        private string CreateHeader()
        {
            StringBuilder sb = new StringBuilder();

            foreach (IBuildPage bp in CreateListOfPages())
            {
                sb.Href(bp.Name + ".html", bp.Name);
                sb.LineBreak();
            }

            return sb.ToString();
        }

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
    }
}
