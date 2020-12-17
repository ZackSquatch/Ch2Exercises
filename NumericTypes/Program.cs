using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string lengthInput;
            int length;
            string widthInput;
            int width;
            
           
            Console.WriteLine("Please enter length of rectangle: ");
            lengthInput = Console.ReadLine();
            length = int.Parse(lengthInput);

            Console.WriteLine("Please enter width width of rectangle: ");
            widthInput = Console.ReadLine();
            width = int.Parse(widthInput);
            int area = length * width;

            Console.WriteLine("The area of your rectangle is " + area);
        }
    }
}
