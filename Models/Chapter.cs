namespace tracking_progress_app.Models
{
    public class Chapter
    {
        public string Title { get; set; } = string.Empty;
        public List<Module> Modules { get; set; }
    }
}
