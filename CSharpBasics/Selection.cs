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
            Console.WriteLine("Great man thats very good for your fucking health");
            break;
            case"food":
            Console.WriteLine("Holy fuck you are gonna be so fucking fat that you cant even fuck");
            break;
            case"games":
            Console.WriteLine("Great myan be a messi");
            break;
            case"swimms":
            Console.WriteLine("Fuck man sharks gonna eat your dick out");
            break;
            default:
            break;
            
        }
    }
}

