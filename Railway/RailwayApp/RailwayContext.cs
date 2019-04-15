namespace RailwayApp
{
    using RailwayApp.Model;
    using System.Data.Entity;

    public class RailwayContext : DbContext
    {
 
        public RailwayContext()
            : base("name=RailwayContext")
        {
        }

         public virtual DbSet<Ticket> Tickets { get; set; }
         public virtual DbSet<Train> Trains { get; set; }
    }


}