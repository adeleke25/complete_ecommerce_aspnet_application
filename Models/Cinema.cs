using System.ComponentModel.DataAnnotations;

namespace Virtual_Ticket.Models
{
    public class Cinema
    {
        [Key]  //class Identifier
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
