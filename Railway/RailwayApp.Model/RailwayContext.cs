namespace RailwayApp.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

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