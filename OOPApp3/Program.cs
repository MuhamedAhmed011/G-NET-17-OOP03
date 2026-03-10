using System.Security.AccessControl;

namespace OOPApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            //a) Composition – The departments depend completely on the university,
            //so if the university is closed the departments no longer exist.

            //b) Association – The driver only uses the car, and both the driver and the car can exist independently.

            //c) Inheritance – A dog is a type of animal, so Dog inherits from the Animal class.

            //d) Aggregation – A team has players, but the players can still exist even if the team is deleted.

            //e) Dependency – The method temporarily uses the logger as a parameter only inside the method. 
            #endregion

            #region Question02
            //a) Yes, a child class in another assembly can access a protected field if it inherits from the parent.
            //No, it cannot be accessed through an object instance from outside.

            //b) protected internal → accessible in the same assembly or by derived classes in other assemblies.
            //private protected → accessible only by derived classes within the same assembly.

            //c) sealed class → cannot be inherited.
            //sealed method → cannot be overridden.

            //d) Yes, you can create an object from a sealed class using new,
            //because sealing only prevents inheritance. 
            #endregion
            #endregion

            #region Part02
            Cinema cinema = new Cinema("IMAX Cinema");

            cinema.OpenCinema();
            Console.WriteLine();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            Console.WriteLine("---------- All Tickets ----------");
            cinema.PrintAllTickets();

            Console.WriteLine();
            Console.WriteLine("---------- Statistics ----------");

            Console.WriteLine("Total Tickets Created: " + Ticket.GetTotalTickets());
            Console.WriteLine();

            Console.WriteLine("Booking Ref 1: " + BookingHelper.GenerateBookingReference());
            Console.WriteLine("Booking Ref 2: " + BookingHelper.GenerateBookingReference());

            Console.WriteLine();

            double discount = BookingHelper.CalcGroupDiscount(5, 100);
            Console.WriteLine("Group Discount (5 × 100 EGP): " + discount + " EGP");

            Console.WriteLine();
            cinema.CloseCinema(); 
            #endregion

        }
    }
}
