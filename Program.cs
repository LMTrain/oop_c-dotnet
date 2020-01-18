using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Object> salesmen = new List<object>() {new CarSalesman("James", "Weaver"), new CarSalesman("Sue", "McGregor"), new RetailSalesPerson("Delores", "Kirby"), new InsuranceBroker("Laycon", "M")};

          foreach(var item in salesmen)
          {
              ShowMeHowToSell(item);
          }
        }

        static void ShowMeHowToSell(Object salesmen)
        {
            if (salesmen is CarSalesman)
            {
                CarSalesman carSalesman = (CarSalesman) salesmen;
                carSalesman.Sell();
            }
            else if (salesmen is RetailSalesPerson)
            {
                RetailSalesPerson retailSalesPerson = (RetailSalesPerson) salesmen;
                retailSalesPerson.Sell();
            }
            else
            {
                InsuranceBroker insuranceBroker = (InsuranceBroker) salesmen;
                insuranceBroker.Sell();
            }
        }
    }
}
