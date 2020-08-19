using System;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"{year} is in the {centuryFromYear(year)}th century!");
            Console.ReadLine();
        }
        public static int centuryFromYear(int year)
        {
            int century;
            if (year % 100 == 0)
                century = year / 100;
            else
                century = year / 100 + 1;

            return century;
        }
    }
}
