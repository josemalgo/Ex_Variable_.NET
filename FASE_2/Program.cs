using System;

namespace FASE_2
{
    class Program
    {
        const int START_YEAR = 1948;

        static void Main(string[] args)
        {
            int leapYearPeriod = 4;
            int totalLeapYears = (1990 - START_YEAR) / leapYearPeriod;

            Console.WriteLine("Hi han " + totalLeapYears + " anys de traspàs.");
        }
    }
}
