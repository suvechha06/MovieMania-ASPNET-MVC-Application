using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship : 1 Producer can produce multiple movies
        public List<Movie> Movies { get; set; }
    }
}
