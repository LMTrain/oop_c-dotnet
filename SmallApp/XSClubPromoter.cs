public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, int cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        throw new System.NotImplementedException();
    }

    protected override void UsePaidAds()
    {
        throw new System.NotImplementedException();
    }
   
    public void Vlog()
    {
        throw new System.NotImplementedException();
    }

   
    public void Workout()
    {
        throw new System.NotImplementedException();
    }

    
}