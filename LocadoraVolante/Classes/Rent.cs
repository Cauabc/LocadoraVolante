using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraVolante.Classes;

namespace LocadoraVolante
{
    public class Rent : Invoice, IRent
    {
        public DateTime dateInitial;
        public DateTime dateFinal;
        public TimeSpan difference;
        private int _hourlyPrice = 50;
        private int _dailyPrice = 130;
        private double _brtax = 0.10;
        public int value;
        public string CarModel { get; set; }
        public int CarId { get; set; }

        public Rent(DateTime date, DateTime finalDate, int CarId, string CarModel)
        {
            dateInitial = date;
            dateFinal = finalDate;
            this.CarId = CarId;
            this.CarModel = CarModel;
        }

        public TimeSpan CalcDate()
        {
            difference = dateFinal - dateInitial;
            return difference;
        }

        public override void GetInvoice()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nota de Pagamento:");
            Console.WriteLine($"Modelo alugado: {CarModel}");
            Console.WriteLine($"ID do Carro alugado: {CarId}");
            Console.WriteLine($"Tempo Alugado: {difference.Days}d e {difference.Hours}h");
            if (difference.Hours <= 12 && difference.Days == 0)
            {
                Console.WriteLine($"Valor das horas de locação: {_hourlyPrice * difference.Hours}");
                value = _hourlyPrice * difference.Hours;
            }
            else
            {
                if (difference.Days == 0)
                {
                    Console.WriteLine($"Valor dos dias de locação: {_dailyPrice * 1}");
                    value = _dailyPrice * 1;

                }
                else
                {
                    Console.WriteLine($"Valor dos dias de locação: {_dailyPrice * difference.Days}");
                    value = _dailyPrice * difference.Days;
                }
            }
            if (value <= 100)
            {
                _brtax = 0.15;
                Console.WriteLine($"Valor final com imposto: {value + value * _brtax}");
            }
            else
            {
                _brtax = 0.20;
                Console.WriteLine($"Valor final com imposto: {value + value * _brtax}");
            }
        }
    }
}