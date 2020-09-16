using System;

class SelectionStatement
{
    static void Main()
    {
        SelectionStatement s = new SelectionStatement();
        s.LearnSwitchStatement();
    }
    void LearnSwitchStatement()
    {
        Console.Write("Enter your hobby:");
        string input = Console.ReadLine();
        switch(input)
        {
            case"books":
            Console.WriteLine("Great man thats very good for your health");
            break;
            case"food":
            Console.WriteLine("you fat ass");
            break;
            case"games":
            Console.WriteLine("sportydude");
            break;
            case"swimms":
            Console.WriteLine("Fuck man sharks gonna eat your heart out");
            break;
            default:
            break;
            
        }
    }
}

