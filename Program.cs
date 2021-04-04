using System;

namespace S2_HW31._03._21
{
    class Program
        
    {
        static void Main(string[] args)
        {
            Event x1 = new();
            Console.WriteLine(x1);
            x1.AddDaysToEvent(5);
            Console.WriteLine(x1);
            x1.AddWeeksToEvent(2);
            Console.WriteLine(x1);
            


        }
    }
}
