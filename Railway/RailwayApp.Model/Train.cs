using RailwayApp.Model.Abstract;
using System;

namespace RailwayApp.Model
{
    public class Train : Entity
    {
        public string Name { get; set; }
        public int CarriageSum{ get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
