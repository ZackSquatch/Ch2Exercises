using System;

namespace MoreOnNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMiles;
            float miles;
            string inputGas;
            float gas;

            Console.WriteLine("Please enter miles driven: ");
            inputMiles = Console.ReadLine();
            miles = float.Parse(inputMiles);

            Console.WriteLine("Please enter gallons of gas used: ");
            inputGas = Console.ReadLine();
            gas = float.Parse(inputGas);

            float mpg = miles / gas;
            Console.WriteLine("You vehicle's miles per gallon is " + mpg);

        }
    }
}
