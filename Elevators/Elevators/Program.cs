using System;
using Elevators.Brain;

namespace Elevators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elevA = new ElevatorA("A");     // created elevator A
            var elevB = new ElevatorB("B");     // created elevator B

            bool havePassengerToTrasport = false;

            do
            {
                Console.Write("What's your floor => ");
                var passenger1 = new Passenger(int.Parse(Console.ReadLine()));   // created passenger in certain floor

                Console.Write("U/D ?");                                          // passenger press button (Up or Down)
                string choice = Console.ReadLine();
                if (choice == "U")
                {
                    passenger1.Up(elevA, elevB);                                 // passenger pressed button Up
                }
                else if (choice == "D")
                {
                    passenger1.Down(elevA, elevB);                               // passenger pressed button Down
                }

                Console.WriteLine("Have passenger to tranport? Y/N");            // checking if we have other passenger or current passenger
                string str = Console.ReadLine();                                 // hasn't reached destination
                if (str == "Y")
                {
                    havePassengerToTrasport = true;
                }
                else if(str == "N")
                {
                    havePassengerToTrasport = false;
                }
            } while (havePassengerToTrasport);

            Console.ReadKey();

        }
    }
}
