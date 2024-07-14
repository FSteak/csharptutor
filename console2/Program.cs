using System;

namespace helix
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; // declaration
            age = 15; // initialization

            int axes = 123; // both
            double helix;
            helix = 6.9;

            char hex;
            hex = '#';

            String hexil;
            hexil = "helix";

            int ages = age + axes;

            Console.WriteLine("You have " + axes + " axes");
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Age + Axes = " + ages);
            Console.WriteLine(hexil + ages + helix);
            Console.WriteLine("yo mom is " + hex + hexil);

            Console.ReadKey();
        }
    }
}