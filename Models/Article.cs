namespace NewProject.Models
{
    /// <summary>
    /// Model danych artykułu.
    /// </summary>
    public class Article
    {
        /// <summary>
        /// Unikalny identyfikator artykułu.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tytuł artykułu.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Treść artykułu.
        /// </summary>
        public string Content { get; set; } = string.Empty;
    }
}

