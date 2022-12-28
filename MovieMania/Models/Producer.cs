using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationship : 1 Producer can produce multiple movies
        public List<Movie> Movies { get; set; }
    }
}
