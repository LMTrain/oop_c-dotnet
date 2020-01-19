using System;

public class RetailSalesPerson : Salesman, SelfDeveloping
{  
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    } 

    public void Develop()
    {
        Console.WriteLine("I develop my skills by watching retail videos online.");
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
        Console.WriteLine("We are offering 80% discount on everything");
    }

    protected override void DemoValue()
    {
       Console.WriteLine("Our customers love it");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this pen.");
    }
}
