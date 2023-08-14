using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora
{
    public class Rent : IRent
    {
        public DateTime dateInitial;
        public DateTime dateFinal;
        public TimeSpan difference;
        public int hourlyPrice = 50;
        public int dailyPrice = 130;

        public Rent(int year, int month, int day, int hour, int yearFinal, int monthFinal, int dayFinal, int hourFinal){
            dateInitial = new DateTime(year, month, day, hour, 0, 0);
            dateFinal = new DateTime(yearFinal, monthFinal, dayFinal, hourFinal, 0, 0);
        }

        public TimeSpan CalcDate(){
            difference = dateFinal - dateInitial;
            Console.WriteLine(difference.Hours);
            return difference;
        }

    }
}