using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Virtual_Ticket.Data.Enums;

namespace Virtual_Ticket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime endDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movie { get; set; }

        //Cinema
        public int CinemaId { get; set; }

        //OneToMany Relationships
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }




    }
}
