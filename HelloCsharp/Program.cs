using System;

namespace HelloCsharp
{
  class Program
  {
      static void Main(string[] args)
      {
        Console.WriteLine("Enter your first name.");
        var firstName =  Console.ReadLine();

        Console.WriteLine("Enter your last name.");
        string lastName =  Console.ReadLine();

        Console.WriteLine(firstName+ " " + lastName) ;
        Console.WriteLine("{0},{1}", firstName, lastName);
        Console.WriteLine($"{firstName} {lastName}");

         Console.ReadLine();
      }
  }
}