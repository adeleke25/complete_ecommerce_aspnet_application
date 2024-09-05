using System.ComponentModel.DataAnnotations;

namespace Virtual_Ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; } // class identifier

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
