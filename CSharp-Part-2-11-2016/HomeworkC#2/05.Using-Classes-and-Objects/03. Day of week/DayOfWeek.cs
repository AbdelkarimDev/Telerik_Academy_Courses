using System;

namespace _03.Day_of_week
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime curentday = new DateTime();
            curentday = DateTime.Now;
            Console.WriteLine(curentday.DayOfWeek);

        }
    }
}
