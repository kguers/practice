using System;
using System.Collections.Generic;
using PizzaShop.Domain.Models;

namespace PizzaShop.Client
{
     class Program
     {
          static void Main()
          {
               Welcome();
          }

          static void Welcome()
          {
               System.Console.WriteLine("Welcome to the Pizza Shop");
               System.Console.WriteLine("Best Pizza in the 462");

               //Ways to Create 1D Arrays
               //string[] cart1 = { " ", " ", " " }; //initial values
               //string[] cart2 = new string[3]; //default values
               //string[] cart3 = new[] { " ", " ", " " }; //initial values - custom datatypes or earlier C# Versions

               //List
               //List<string> cart4 = new List<string> { " ", " ", " " };//initial values
               List<Pizza> cart5 = new List<Pizza>();//default values

               var su = new Starter();
               var user = new User();
               var store = new Store();
               //var order = su.CreateOrder(user, store);
               try
               {
                         Menu(su.CreateOrder(user, store));
               }
               catch (Exception ex)
               {
                         System.Console.WriteLine(ex.Message);
               }
          }

          static void Menu(Order cart)
          {
               var order = true;
               do
               {
                    Starter.PrintMenu();

                    int select;

                    int.TryParse(Console.ReadLine(), out select);

                    switch (select)
                    {
                         case 1:
                              cart.CreatePizza("L", "Regular", new List<string> { "Cheese" });
                              System.Console.WriteLine("Added Cheese Pizza");
                              break;
                         case 2:
                              cart.CreatePizza("L", "Regular", new List<string> { "Cheese, Pepperoni" });
                              System.Console.WriteLine("Added Pepperoni Pizza");
                              break;
                         case 3:
                              cart.CreatePizza("L", "Regular", new List<string> { "Cheese, Pineapple, Ham" });
                              System.Console.WriteLine("Added Hawaiian Pizza");
                              break;
                         case 4:
                              cart.CreatePizza("L", "Regular", new List<string> { "Cheese, Pepperoni, Sausage, Meatball, Bacon" });
                              System.Console.WriteLine("Added Meat Lovers Pizza");
                              break;
                         case 5:
                              cart.CreatePizza("L", "Regular", new List<string> { "Cheese, Buffalo, Chicken, Ranch" });
                              System.Console.WriteLine("Added Custom Pizza");
                              break;
                         case 6:
                              var fmw = new FileManager();
                              fmw.Write(cart);
                              break;
                         case 7:
                              var fmr = new FileManager();
                              DisplayCart(fmr.Read());
                              break;
                         case 8:
                              System.Console.WriteLine("Exit Pizza");
                              order = false;
                              break;
                    }

               } while (order);
          }

          static void DisplayCart(Order cart)
          {
               int cnt = 1;
               foreach (var pizza in cart.Pizzas)
               {
                    System.Console.WriteLine("Pizza " + cnt + ": " + pizza.ToString());
                    cnt += 1;
               }
          }
     }
}
