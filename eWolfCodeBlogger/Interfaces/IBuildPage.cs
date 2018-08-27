namespace eWolfCodeBlogger.Interfaces
{
    public interface IBuildPage
    {
        string Tags { get; }

        void BuildPage();

        string Output();
    }
}
