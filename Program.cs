using System;

namespace Csharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARE CONSTANTS and VARIABLEs
            // and SET THEIR INITIAL VALUES as INDICATED
            

            // Compare sample1 and sample2

            byte sample1 = 0x3A;
            byte sample2 = 58;

            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            // Create if statment for HEARTRATE

            int heartRate = 85;

            if ((heartRate >= 40) && (heartRate <= 80))
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }

            // is statment for DEPOSITS

            double deposits = 135002796;

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }


            // Used the F to create a floating point literal
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double force = mass * acceleration;
            Console.WriteLine($"force = {force}");


            double distance = 129.763001;
            Console.WriteLine($"{distance} is the distance.");


            bool lost = true;
            bool expensive = true;

            if ((lost == true) && (expensive == true))
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if ((lost == true) && (expensive == false))
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }



            int choice = 2;

            if (choice == 1)
            {
                Console.WriteLine("You chose 1.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose 2.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose 3.");
            }
            else if (choice > 3)
            {
                Console.WriteLine("You made an unknown choice.");
            }

            // I'm getting an error that the integral does not exist in the context
            // The integral (/u222B) can't be read
            const char integral = /u222B;
            Console.WriteLine($"{integral} is an integral.");

            // Created a for loop
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            // Created a while loop
            int age = 0;

            while (age < 6)
            {
                Console.WriteLine($"age = {age}");
                age = age + 1;
            }
        
            // Strings with space between

            string greetings = "Hello";
            string name = "Karen";
            string space = (greetings + "   " + name);
            Console.WriteLine(space);

        }
    }
}
