using System;

namespace Elevators.Brain
{
    class ElevatorB : Elevator
    {
        private const int unAvailableFloor = -1;

        public ElevatorB(string name) :
            base(name)
        {
        }

        public override void Ride(int floor)
        {
            if (floor == unAvailableFloor)
            {
                Console.WriteLine($">{Name}:Close doors");
                Console.WriteLine($">{Name}:Move to 0");
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
