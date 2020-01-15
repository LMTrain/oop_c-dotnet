public class CarSalesman
{
    private string _firstName; //BEST PRACTICE - MAKE FIELD PRIVATE

    private string _lastName; //BEST PRACTICE - MAKE FIELD PRIVATE

    //BEST PRACTICE - MAKE PROPERTIES PUBLIC
    public string FullName   
    {
        get
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }
    public CarSalesman(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }
}