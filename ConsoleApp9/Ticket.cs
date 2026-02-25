using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Ticket
    {
        private static int counter = 0;
        private static int bookingCounter = 0;
        public string BookingReference { get; }
        public string MovieName { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentException("Price must be greater than 0");
            }
        }

        public int TicketId { get; }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            TicketId = ++counter;
            BookingReference = "BK-" + (++bookingCounter);
        }
        public virtual decimal PriceAfterTax
{
    get { return Price * 1.14m; }
}

        public static int GetTotalTickets()
        {
            return counter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}
