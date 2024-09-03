using System.ComponentModel.DataAnnotations;

namespace Virtual_Ticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; } // class identifier

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        //Relationshiop
        public List<Actor_Movie> Actor_Movie { get; set; }

    }
}
