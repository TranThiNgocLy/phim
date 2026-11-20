namespace phim.Models

{
    public class genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Movie> Movies { get; set; } = new();
    }
}
