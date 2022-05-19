using MovieWebApp.Models;

namespace MovieWebApp.MovieViewModel
{
    public class MovieViewModel
    {

        public Movie Movie { get; set; }    
        public Genre Genre { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
