using System;
public class CarSalesman : Salesman
{ 
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    
    protected override void Engage()
    {
        Console.WriteLine("Hello!");
    }

    protected override void EstablishTrust()
    {
        Console.WriteLine("I just want to help you.");
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("We are offering 10% discount on everything");
    }

    protected override void DemoValue()
    {
       Console.WriteLine("Our customers love it");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this car.");
    }
}