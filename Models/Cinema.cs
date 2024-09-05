using System.ComponentModel.DataAnnotations;

namespace Virtual_Ticket.Models
{
    public class Cinema
    {
        [Key]  //class Identifier
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Discription")]
        public string Description { get; set; }


        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
