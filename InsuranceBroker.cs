using System;

public class InsuranceBroker : Salesman
{  
    public InsuranceBroker(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    
    public override void Sell()
    {
        Console.WriteLine(String.Format("Hi my name is {0}. I would recommend you to buy this Insurance!", this.FullName));
    }

}
