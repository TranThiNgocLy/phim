using System.ComponentModel.DataAnnotations;

namespace phim.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int Duration { get; set; }    

        public int GenreId { get; set; }       
        public genre? Genre { get; set; }
    }
}
