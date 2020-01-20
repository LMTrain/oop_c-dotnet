using System;

public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my Instagram followers.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use FaceBook ads.");
    }
   
    public void Vlog()
    {
        Console.WriteLine("I use a DSLR in order to vLog.");
    }

   
    public void Workout()
    {
        Console.WriteLine("I workout at home.");
    }

    
}