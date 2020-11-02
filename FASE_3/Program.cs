using System;

namespace FASE_3
{
    class Program
    {
        const int YEAR_BIRTH = 1990;

        static void Main(string[] args)
        {
            int startYear;
            
            bool validLeapYear = false;
            var affirmMessage = "El meu any de naixement és de traspas.";
            var negativeMessage = "El meu any de naixement no és de traspas.";
            
            string name = "Jose María", surname = "Álvarez", secondSurname = "González";
            int day = 28, month = 09, year = 1990;
            var fullName = name + " " + surname + " " + secondSurname;
            var birthdate = day + "/" + month + "/" + year;

            for (startYear = 1948; startYear <= YEAR_BIRTH; startYear++)
            {
                if (((startYear % 4 == 0) && (startYear % 100 != 0)) || (startYear % 400 == 0))
                {
                    if(startYear == YEAR_BIRTH)
                    {
                        validLeapYear = true;
                    }

                    Console.WriteLine(startYear);
                }
            }

            Console.WriteLine("El meu nom complet és " + fullName);
            Console.WriteLine("Vaig néixer el " + birthdate);

            if (validLeapYear)
                Console.WriteLine(affirmMessage);
            else
                Console.WriteLine(negativeMessage);



        }
    }
}
