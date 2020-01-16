using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman steveTheSalesman = new CarSalesman("Steve", "Rogers");
            Console.WriteLine(steveTheSalesman.FullName);
            steveTheSalesman.Sell();

            RetailSalesPerson erikTheSalesdude = new RetailSalesPerson("Erik", "Erikson");
            Console.WriteLine(erikTheSalesdude.FullName);
            erikTheSalesdude.Sell();

        }
    }
}
