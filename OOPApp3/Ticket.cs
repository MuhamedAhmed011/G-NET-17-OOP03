using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPApp3
{
    public class Ticket
    {
        private string movieName;
        private decimal price;
        private static int counter = 0;

        public int TicketId { get; }

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    movieName = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public decimal PriceAfterTax
        {
            get { return price * 1.14m; }
        }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;

            counter++;
            TicketId = counter;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP";
        }

        public static int GetTotalTickets()
        {
            return counter;
        }
    }
}
