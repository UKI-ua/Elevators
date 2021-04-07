using System;

namespace Elevators.Brain
{
    abstract class Elevator
    {
        private string name_;
        private int certainFloor_ = 0;
        private bool isDoorsOpen_;

        public int CertainFloor { get => certainFloor_; set => certainFloor_ = value; }
        public string Name { get => name_; set => name_ = value; }
        public bool IsDoorsOpen { get => isDoorsOpen_; set => isDoorsOpen_ = value; }

        public Elevator(string name)
        {
            Name = name;
        }

        public void TakePassenger(int floor)
        {
            if (IsDoorsOpen)
            {
                Console.WriteLine($">{Name}:Close doors");
            }

            Console.WriteLine($">{Name}:Move to {floor}");
            Console.WriteLine($">{Name}:Open doors");
            CertainFloor = floor;
        }
        public abstract void Ride(int floor);
    }
}
