using LocadoraVolante;

Console.WriteLine("Olá!, seja bem vindo(a) à Locadora Volante");
Console.WriteLine("Digite as informações de locação feita: ");

Console.WriteLine("ID do Carro: ");
int CarId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Modelo do Carro: ");
string? CarModel = Console.ReadLine();

Car c1 = new(CarId, CarModel);

Console.WriteLine("------------------");

Console.WriteLine("Qual data e hora você alugou o Carro? Ex: (dd/MM/yyyy hh:mm)");

DateTime date = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Qual data você devolveu o Carro? Ex: (dd/MM/yyyy hh:mm)");
DateTime finalDate = DateTime.Parse(Console.ReadLine());

Rent r1 = new(date, finalDate, c1.id, c1.model);
r1.CalcDate();
r1.GetInvoice();



