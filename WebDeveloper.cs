using System;

public class WebDeveloper: Developer
{
    public WebDeveloper(string mainDevLanguage) :base(mainDevLanguage)
    {
    }

     public void Develop()
    {
        Console.WriteLine("I develop my skills by watching Udemy web development videos online.");
    }
}