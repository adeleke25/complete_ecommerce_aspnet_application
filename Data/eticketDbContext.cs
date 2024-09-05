using Microsoft.EntityFrameworkCore;
using Virtual_Ticket.Models;

namespace Virtual_Ticket.Data
{
    public class eticketDbContext : DbContext //Injection of base class
    {
        public eticketDbContext(DbContextOptions<eticketDbContext> options)
            : base(options) //constructor
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movie).HasForeignKey(
                m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.ActorMovie).HasForeignKey(
                m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //TableName for each model
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movie { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }






    }
}
