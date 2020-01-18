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

            CarSalesman erikTheSalesdude = new CarSalesman("Erik", "Erikson");
            Console.WriteLine(erikTheSalesdude.FullName);
            erikTheSalesdude.Sell();

            RetailSalesPerson johnTheSalesdude = new RetailSalesPerson("John", "Doe");
            Console.WriteLine(erikTheSalesdude.FullName);
            erikTheSalesdude.Sell();

        }
    }
}
