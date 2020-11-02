using System;

namespace FASE_3
{
    class Program
    {
        const int YEAR_BIRTH = 1990;

        static void Main(string[] args)
        {
            int START_YEAR;
            
            bool validLeapYear = false;
            var affirmMessage = "El meu any de naixement és de traspas.";
            var negativeMessage = "El meu any de naixement no és de traspas.";
            
            string name = "Jose María", surname = "Álvarez", secondSurname = "González";
            int day = 28, month = 09, year = 1990;
            var fullName = name + " " + surname + " " + secondSurname;
            var birthdate = day + "/" + month + "/" + year;

            for (START_YEAR = 1948; START_YEAR <= YEAR_BIRTH; START_YEAR++)
            {
                if (((START_YEAR % 4 == 0) && (START_YEAR % 100 != 0)) || (START_YEAR % 400 == 0))
                {
                    if(START_YEAR == YEAR_BIRTH)
                    {
                        validLeapYear = true;
                    }

                    Console.WriteLine(START_YEAR);
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
