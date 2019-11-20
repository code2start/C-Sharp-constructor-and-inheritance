using System;

namespace constructorandinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Employee e1 = new Employee(1, "Mohamed Fathy", "Arabic");
            Console.WriteLine(e1.Name);
        }
    }
}
