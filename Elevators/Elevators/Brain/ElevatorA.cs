using System;

namespace Elevators.Brain
{
    class ElevatorA : Elevator
    {
        private const int inaccessibleFloor = 10;

        public ElevatorA(string name):
            base(name)
        {
        }

        public override void Ride(int floor)
        {
            if (floor == inaccessibleFloor)
            {
                Console.WriteLine($">{Name}:Close doors");
                Console.WriteLine($">{Name}:Move to 9");
                Console.WriteLine($">{Name}:Open doors");
                IsDoorsOpen = true;
                CertainFloor = floor;
            }
            else
            {
                Console.WriteLine($">{Name}:Close doors");
                Console.WriteLine($">{Name}:Move to {floor}");
                Console.WriteLine($">{Name}:Open doors");
                IsDoorsOpen = true;
                CertainFloor = floor;
            }
        }
    }
}
