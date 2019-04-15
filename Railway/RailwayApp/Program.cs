using Railway.Service;
using RailwayApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RailwayApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TicketChecker ticketChecker = new TicketChecker();

            Train train = new Train
            {
                Name = "713PXF D3",
                CarriageSum = 20,
                CreatedTime = DateTime.Parse("13.02.2001")
            };


            Ticket ticket = new Ticket
            {
                FromCity = "Нур-Султан",
                ToCity = "Москва",
                Price = 15750,
                DepartureTime = DateTime.Parse("20.04.2019"),
                ArrivalTime = DateTime.Parse("22.04.2019"),
                TypeOfPlace = TypeOfPlace.Coupe,
                Train = train,
                TrainId = train.Id
            };

            List<string> fromList = new List<string>();
            fromList.Add(ticket.FromCity);
            List<string> toList = new List<string>();
            toList.Add(ticket.ToCity);

            Console.WriteLine("\t\tRailway \"Matumba\"\nFrom:");
            string from = Console.ReadLine();
            Console.WriteLine("To:");
            string to = Console.ReadLine();
            if (ticketChecker.HaveGotTicket(from, to, fromList, toList))
            {
                using (var context = new RailwayContext())
                {
                    List<Ticket> result = context.Tickets.SqlQuery($"select * from tickets where FromCity = '@from' ",new SqlParameter("@from", from)).ToList();
                    Console.WriteLine($"From:{from} to {to}\n Price:{result.FirstOrDefault().Price}");
                }

            }


            Console.ReadLine();


        }
    }
}
