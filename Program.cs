using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Salesman> salesmen = new List<Salesman>() {new CarSalesman("James", "Weaver"), new CarSalesman("Sue", "McGregor"), new RetailSalesPerson("Delores", "Kirby"), new InsuranceBroker("Laycon", "M"), new OnlineMarketer("Steve", "Williams")};

          foreach(var item in salesmen)
          {
              ShowMeHowToSell(item);
          }

          List<SelfDeveloping> selfDeveloping = new List<SelfDeveloping>() {new RetailSalesPerson("Delores", "Kirby"), new WebDeveloper("C#")};

          foreach(var item in selfDeveloping)
          {
              ShowMeHowToSellDevelop(item);
          }
        }

        static void ShowMeHowToSell(Salesman salesmen)
        {
            salesmen.Sell();
        }

        static void ShowMeHowToSellDevelop(SelfDeveloping SelfDeveloping)
        {
            SelfDeveloping.Develop();
        }
    }
}
