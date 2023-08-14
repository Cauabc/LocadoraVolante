using System;

namespace Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!, seja bem vindo(a) à Locadora Volante");
            Console.WriteLine("Digite as informações de locação feita: ");

            Console.WriteLine("ID do Carro: ");
            int CarId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Modelo do Carro: ");
            string CarModel = Console.ReadLine();

            Car c1 = new Car(CarId, CarModel);

            Console.WriteLine("Que data você alugou o Carro?");
            Console.Write("Dia: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mês: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ano: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Horário: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Que data você devolveu o Carro?");
            Console.Write("Dia: ");
            int dayFinal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mês: ");
            int monthFinal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ano: ");
            int yearFinal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Horário: ");
            int hourFinal = Convert.ToInt32(Console.ReadLine());

            Rent r1 = new Rent(year, month, day, hour, yearFinal, monthFinal, dayFinal, hourFinal);
            r1.CalcPrice();
            Console.WriteLine(c1.model);
        }
    }
}
