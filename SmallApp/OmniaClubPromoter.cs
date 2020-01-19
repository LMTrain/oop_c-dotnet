public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, int cellPhone) : base(firstName, lastName, cellPhone)
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
}