using System;
using Elevators.Brain;

namespace Elevators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elevA = new ElevatorA("A");
            var elevB = new ElevatorB("B");

            Console.Write("What's your floor => ");
            var passenger1 = new Passenger(int.Parse(Console.ReadLine()));
            
            Console.Write("U/D ?");
            string choice = Console.ReadLine();
            if (choice == "U")
            {
                passenger1.Up(elevA, elevB);
            }
            else if (choice == "D")
            {
                passenger1.Down(elevA, elevB);
            }
            Console.ReadKey();

        }
    }
}
