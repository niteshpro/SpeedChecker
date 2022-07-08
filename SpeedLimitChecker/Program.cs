//Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

using System;

namespace SpeedCheckSystem
{
   class Program
    {
        static void Main()
        {
            int speedLimit = 0, carSpeed=0;
            int overSpeed = 0;
            Console.WriteLine("Enter the speed limit \n ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Enter the Car speed \n ");
            carSpeed = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine( "--------------------------------- \n Speed Limit in this area is: "+speedLimit + "\n--------------------------------- \n");
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                overSpeed =    (carSpeed - speedLimit)/5;
                Console.WriteLine("Demerits points are: " + overSpeed);

            }



        }
    }


}