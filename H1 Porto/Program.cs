using System;

namespace Porto
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many grams does the letter weight?");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the height on the letter?");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the length of the letter");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the letter?");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Where should the letter be send to?");
            string location = (Console.ReadLine());
            int danmarkPorto = 12;
            int everywherePorto = 36;
            double volume = (double)height * width * length;

            //Validation
            if (weight > 2000)
            {
                Console.WriteLine("A letter can't weight more than 2 kg ");
            }
            else if (length > 60)
            {
                Console.WriteLine("A letter cant be more than 2 kg, you have to use a package instead");
            }
            else if (volume > 90)
            {
                Console.WriteLine("Letter can't have a volume above 90 cm3");
            }
            
            if (weight < 50)
            {
                danmarkPorto = 12;
                everywherePorto = 36;
                Console.WriteLine("under 50");
            }
            else if (weight > 50 && weight < 100)
            {
                danmarkPorto = 24;
                everywherePorto = 36;
                Console.WriteLine("Under 100");
            }
            else if (weight > 100 && weight < 250)
            {
                danmarkPorto = 48;
                everywherePorto = 72;
                Console.WriteLine("under 250");
            }
            else if (weight > 250 && weight < 500)
            {
                danmarkPorto = 60;
                everywherePorto = 96;
                Console.WriteLine("under 500");
            }
            else if (weight > 500 && weight < 1000)
            {
                danmarkPorto = 60;
                everywherePorto = 96;
                Console.WriteLine("under 1000");
            }
            else if (weight > 1000 && weight < 2000)
            {
                danmarkPorto = 60;
                everywherePorto = 96;
                Console.WriteLine("under 2000");     
            }

            if (location.ToLower() == "denmark")
            {
                Console.WriteLine("It will cost "+danmarkPorto+" dkk");
            }
            else
            {
                Console.WriteLine("Its not in Denmark, so it will cost " + everywherePorto + " dkk");
            }
        }
    }
}