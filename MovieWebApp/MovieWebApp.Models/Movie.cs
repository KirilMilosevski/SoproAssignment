using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10!")]


        public int Rating { get; set; }
        public string Link { get; set; }
        public int ReleaseDate { get; set; }

        public string Photo { get; set; }


        public string AdditionalCast { get; set; }



    }
}
