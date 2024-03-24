using System;

namespace total
{
    class Program
    {
        static void Main(string[] args)
        {
            //total = mpg / miles + tolls + fees;
            double miles;
            double cost;
            double mpg;
            double fees;
            double tolls;
            double total;

            Console.Write("Total Miles Per Day: ");
            miles = double.Parse(Console.ReadLine());

            Console.Write("Cost per Gallon (in cents): ");
            cost = double.Parse(Console.ReadLine());

            Console.Write("Average Miles per Gallon: ");
            mpg = double.Parse(Console.ReadLine());

             Console.Write("Parking fees per day (in cents): ");
             fees = double.Parse(Console.ReadLine());
                
             Console.Write("Tolls per Day (in cents): ");
            tolls = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Cost of Driving Per Day");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine($"Total Miles per Day: {miles}");
            Console.WriteLine($"Cost per Gallon: {cost}");
            Console.WriteLine($"Average Miles per Gallon: {mpg}");
            Console.WriteLine($"Parking Fees per Day: {fees}");
            Console.WriteLine($"Tolls per Day: {tolls}");

            Console.WriteLine("------------------------------------------------");

            total = mpg / miles + tolls + fees;
            Console.WriteLine($"You could save $ {total} per day by carpooling.");
            

        }
    }
}
