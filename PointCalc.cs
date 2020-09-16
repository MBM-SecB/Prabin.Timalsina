using System;

public class PointCalc
{
     static void Main2(){
       TotalPoints points= new TotalPoints();
       p.Tpoints();
    }
    public void Tpoints(){
        Console.Write("No of wins:");
       win=Convert.ToInt32(Console.ReadLine());
       Console.Write("No of loss:");
       loss= Convert.ToInt32(Console.ReadLine());
       Console.Write("no of Draw:");
       draw= Convert.ToInt32(Console.ReadLine());
       win= win*5;
       draw=draw*2;
       loss=0;
       overallscore=win+draw+loss;
       Console.WriteLine($"Total Point:{points}");
    }
}