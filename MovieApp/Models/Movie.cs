namespace MovieApp.Models
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }
        public string[] Actors { get; set; }
        public string GenreId { get; set; }
    }
}
