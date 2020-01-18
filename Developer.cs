using System;

public abstract class Developer
{
    private string _mainDevLanguage;

    
    public Developer(string mainDevLanguage)
    {
        this._mainDevLanguage = mainDevLanguage;
        
    }
    
    public virtual void Code()
    {
        Console.WriteLine(String.Format("Hi my name is {0}. I would recommend you to buy this item!", this._mainDevLanguage));
    }
}