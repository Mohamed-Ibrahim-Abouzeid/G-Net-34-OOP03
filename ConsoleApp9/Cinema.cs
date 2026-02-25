using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
     class Cinema
    {
        public string CinemaName { get; set; }
        private Projector projector;
        private Ticket[] tickets = new Ticket[20];

        public Cinema(string name)
        {
            CinemaName = name;
            projector = new Projector(); // Composition
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
            Console.WriteLine("Cinema is full!");
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");

            foreach (var t in tickets)
            {
                if (t != null)
                    Console.WriteLine(t);
            }

            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            Console.WriteLine();
            int count = 1;
            foreach (var t in tickets)
            {
                if (t != null)
                {
                    Console.WriteLine($"Booking Ref {count}: {t.BookingReference}");
                    count++;
                }
            }

            // Group Discount Example (5 tickets x 100 EGP)
            decimal total = 5 * 100;
            decimal discounted = total * 0.9m;

            Console.WriteLine();
            Console.WriteLine($"Group Discount (5 x 100 EGP): {discounted} EGP (10% off)");
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            projector.Stop();
        }
    }
}
