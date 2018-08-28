namespace eWolfCodeBlogger.Interfaces
{
    public interface IBuildPage
    {
        string Name { get; }

        string Tags { get; }

        void BuildPage();

        string Output();
    }
}
