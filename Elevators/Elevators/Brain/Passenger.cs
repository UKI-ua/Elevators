using System;

namespace Elevators.Brain
{
    class Passenger
    {
        private int certainFloor_;

        public int CertainFloor { get => certainFloor_; set => certainFloor_ = value; }

        public Passenger(int certainFloor)
        {
            CertainFloor = certainFloor;
        }

        public void Up(ElevatorA A, ElevatorB B)
        {
            switch (CertainFloor)
            {
                case 9:                                             // only elevator B can reach 10th floor
                    B.TakePassenger(CertainFloor);
                    Console.WriteLine("Choose the floor:");
                    B.Ride(int.Parse(Console.ReadLine()));
                    break;
                case -1:                                            // only elevator A can go down on -first floor
                    A.TakePassenger(CertainFloor);
                    Console.WriteLine("Choose the floor:");
                    A.Ride(int.Parse(Console.ReadLine()));
                    break;
                default:
                    if (Math.Abs(A.CertainFloor - CertainFloor) < Math.Abs(B.CertainFloor - CertainFloor))  // checkin which elevator is closer to passenger
                    {
                        A.TakePassenger(CertainFloor);
                        Console.WriteLine("Choose the floor:");
                        A.Ride(int.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        B.TakePassenger(CertainFloor);
                        Console.WriteLine("Choose the floor:");
                        B.Ride(int.Parse(Console.ReadLine()));
                    }
                    break;
            }
        }

        public void Down(ElevatorA A, ElevatorB B)
        {
            switch (CertainFloor)
            {
                case 0:                                                 // only elevator A can go down on -first floor
                    A.TakePassenger(CertainFloor);
                    Console.WriteLine("Choose the floor:");
                    A.Ride(int.Parse(Console.ReadLine()));
                    break;
                case 10:                                                // only elevator B can reach 10th floor
                    B.TakePassenger(CertainFloor);
                    Console.WriteLine("Choose the floor:");
                    B.Ride(int.Parse(Console.ReadLine()));
                    break;
                default:
                    if (Math.Abs(A.CertainFloor - CertainFloor) < Math.Abs(B.CertainFloor - CertainFloor))  // checkin which elevator is closer to passenger
                    {
                        A.TakePassenger(CertainFloor);
                        Console.WriteLine("Choose the floor:");
                        A.Ride(int.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        B.TakePassenger(CertainFloor);
                        Console.WriteLine("Choose the floor:");
                        B.Ride(int.Parse(Console.ReadLine()));
                    }
                    break;
            }
        }
    }
}
