using System;

namespace Basic_construct_for__day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Im happy");

            String name = Console.ReadLine();
            Console.WriteLine("NO oF Plates?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine(count);
           // Console.WriteLine(typeof(name),typeof(count));
            if (count >= 2)
            {
               
                Console.WriteLine("too much of snacks ");
            }

        }
    }
}
