namespace Miniblog.Core
{
    public class BlogSettings
    {
        public string Name { get; set; } = "Aivaras Šimulis";
        public string Description { get; set; } = "A simplistic approach to web development";
        public string Owner { get; set; } = "Aivaras Šimulis";
        public int PostsPerPage { get; set; } = 5;
        public int CommentsCloseAfterDays { get; set; } = 14;
    }
}
