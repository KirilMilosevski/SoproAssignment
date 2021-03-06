using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Person
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Role { get; set; }
    }
}
