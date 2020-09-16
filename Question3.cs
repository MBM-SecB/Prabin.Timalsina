using System;
public class magic{
    static void Main3(string[]args){
        magic m= new magic();
        m=GetInitials();
    }
    public void GetInitials()
    {
        Console.Write("Enter two diff. words:");
        string p=Console.ReadLine();
        string[] vs = p.Split(''); 
        if (output.Length!=2);{
            Console.WriteLine("Error , enter valid input");
        }
        foreach(string a in output){
            Console.Write(a[0]);
        }

    }
}