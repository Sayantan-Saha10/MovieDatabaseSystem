namespace MovieDatabaseSystem.Common.Models.ViewModels
{
    public class MovieDatabaseRecordViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public string Runtime { get; set; }
        public string ReleasedDate { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
    }
}