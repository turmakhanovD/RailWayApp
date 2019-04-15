using System;
using RailwayApp.Model.Abstract;

namespace RailwayApp.Model
{
    public class Ticket : Entity
    {
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public int Price { get; set; }
        public virtual Train Train { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public TypeOfPlace TypeOfPlace { get; set; }
        public Guid TrainId { get; set; }
    }
}
