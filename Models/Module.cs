namespace tracking_progress_app.Models
{
    public class Module
    {
        public string Title { get; set; } = string.Empty;
        public List<Lesson> Lessons { get; set; }
    }
}