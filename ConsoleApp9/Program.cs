using System.ComponentModel;
using System.Reflection.Metadata;

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
                #endregion
        }
    }
}
