using System;

namespace Calculator
{
     class Program
     {
      static void Main(string[] args)
     {
          Console.WriteLine("Welcome to my Basic Bitch Calulator");
          var stay = true;
           do
          {
               Console.WriteLine("Menu");
               Console.WriteLine("Press 1 for Addition");
               Console.WriteLine("Press 2 for Subtraction");
               Console.WriteLine("Press 3 for Multiplication");
               Console.WriteLine("Press 4 for Division");

               string choice = Console.ReadLine();

               /*var input1 = (double)Console.ReadLine(); //explicit w/ exception
               var input2 = Console.ReadLine() as double; //explicit w/ null
               
               System.Console.WriteLine("Enter first operand");
               var input1 = double.Parse(Console.ReadLine()); //explicit parsing with 0

               System.Console.WriteLine("Enter second operand");
               double input2; double.TryParse(Console.ReadLine(), out input2); //explicit parsing with exception
               
               if(choice.Equals("1") || choice.Equals("2") || choice.Equals("3")|| choice.Equals("4")){
                    stay=false;
                    continue;
               }*/

               System.Console.WriteLine("Enter first operand");
               double input1;  
               if(double.TryParse(Console.ReadLine(), out input1)){
                         System.Console.WriteLine("valid");
               }
               else{
                     System.Console.WriteLine("not valid");                   
               }

               System.Console.WriteLine("Enter second operand");
               double input2; 
               if(double.TryParse(Console.ReadLine(), out input2)){
                    System.Console.WriteLine("valid");
               }
               else{
                    System.Console.WriteLine("not valid");
               }

               switch (choice)
               {
               case "1":
                    Add(input1, input2);
                    break;
               case "2":
                    Subtract(input1, input2);
                    break;
               case "3":
                    Multiply(input1, input2);
                    break;
               case "4":
                    Divide(input1, input2);
                    break;
               default:
                    stay = false;
                    break;
               }
          }   while (stay);
    }
    static void Add(double x, double y)
    {
      var result = x + y;
      System.Console.WriteLine($"Your answer is: {result}");
    }

    static void Subtract(double x, double y)
    {
      var result = x - y;
      System.Console.WriteLine($"Your answer is: {result}");
    }
    static void Multiply(double x, double y)
    {
      var result = x * y;
      System.Console.WriteLine($"Your answer is: {result}");
    }

    static void Divide(double x, double y)
    {
      var result = x / y;
      var remainder = x % y;
      System.Console.WriteLine($"Your answer is: {result} remainder {remainder}");
    }
  }
}
