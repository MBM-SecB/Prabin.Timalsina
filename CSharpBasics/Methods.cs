using System;
public class MethodTeacher{
   public int Multiply(int firstNum,int secondNum){
     int result= firstNum*secondNum;
     return result;
    }

    public int Multiply( params int[] numbers){
     int product=1;
     foreach(int num in numbers){
         product= product*num;
     }
     return product;
    }
     internal void PrintCustomerDetails(String Name, byte age, string address, DateTime dob)
    {
        //using string interpolation here $"{}
    Console.Write($"Customer Details :{Name} ,{age}, {address},{dob}");
    }
    // returning multiple values
    (int , string) DoSomething(int x)
    {
        return(365,"");
    }
    //max and min value for supplie numbers
    static void Main()
    {
        int[] array1 = { 1, -1, -2, 0 };

        
        Console.WriteLine(array1.Max());

    
        Console.WriteLine(array1.Min());
    }
}
}

public class MethodTester{
    void TestMethods(){
        MethodTeacher methodTeacher=new MethodTeacher();
        int product=methodTeacher.Multiply(2345, 56483);
        
        int product1 =methodTeacher.Multiply(1234,3456,5765,67543);
        methodTeacher.PrintCustomerDetails(dob: DateTime.Now, nameof: Patrick, Address:"36th street, new orleans", age:23);
    }
}