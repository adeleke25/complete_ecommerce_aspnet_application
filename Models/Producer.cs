using System.ComponentModel.DataAnnotations;

namespace Virtual_Ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; } // class identifier

        public string ProfilePictureURl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
