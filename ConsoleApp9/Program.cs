using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            //            a) A University has Departments. If the university is closed, the departments no longer exist.
            //-> Composition
            //Because the departments cannot exist without the university.

            //b) A Driver uses a Car.The driver does not own the car.
            //-> Association
            //Because the driver just uses the car, but both can exist independently.

            //c) A Dog is an Animal.
            //-> Inheritance
            //Because Dog is a type of Animal(IS-A relationship).

            //d) A Team has Players. If the team is deleted, the players still exist.
            //-> Aggregation
            //Because players can exist without the team.

            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //-> Dependency
            //Because the method temporarily depends on Logger to do something.
            #endregion
            #region Q2
            //            a)

            //Yes, a child class in a different assembly can access a protected field, but only through inheritance(inside the child class).

            //No, it cannot access it using an object instance from outside the class.

            //b)

            //protected internal -> Accessible from the same assembly OR from derived classes in other assemblies.

            //private protected -> Accessible only within the same assembly AND only in derived classes.

            //c)

            //When sealed is applied to a class -> The class cannot be inherited.

            //When sealed is applied to a method -> The method cannot be overridden again in further derived classes.

            //d)
            //Yes, you can create an object from a sealed class using new.
            //Sealed only prevents inheritance, not object creation.
            #endregion
            #endregion
            #region Part2
            Cinema cinema = new Cinema("Galaxy Cinema");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            cinema.CloseCinema();
            #endregion
        }
    }
}
