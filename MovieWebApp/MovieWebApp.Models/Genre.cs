using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Genre
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
