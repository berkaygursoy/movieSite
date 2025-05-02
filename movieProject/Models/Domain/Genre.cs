using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string GenreName { get; set; }
    }
}
