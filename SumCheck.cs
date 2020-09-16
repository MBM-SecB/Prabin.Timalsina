using System;
public class sumcheck
{
     static void Main1(){
         sumcheck k=new sumcheck();
         k.Sum();
     }
     public bool Sum()
     {
         Console.Write("Enter first number: ");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());
        int sum=firstNum+secondNum;
        var p=sum>500? true:false;
        return p;

     }
    }
  