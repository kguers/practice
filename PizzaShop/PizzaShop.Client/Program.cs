using System;
using System.Collections.Generic;
using PizzaShop.Domains.Models;

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

               Menu(cart5);
          }

          static void Menu(List<Pizza> cart)
          {
               var order = true;
               var num = 0;
               var startup = new PizzaShop.Client.Startup();
               do
               {
                    if (num < 10)
                    {

                         System.Console.WriteLine("Select 1 for Cheese Pizza");
                         System.Console.WriteLine("Select 2 for Pepperoni Pizza");
                         System.Console.WriteLine("Select 3 for Hawaiian Pizza");
                         System.Console.WriteLine("Select 4 for Meat Lovers Pizza");
                         System.Console.WriteLine("Select 5 for Custom Pizza");
                         System.Console.WriteLine("Select 6 to Display Cart");
                         System.Console.WriteLine("Select 7 for Exit Pizza");

                         int select;
                         int.TryParse(Console.ReadLine(), out select);

                         switch (select)
                         {
                              case 1:
                                   var p1 = startup.CreatePizza("L", "Regular", new List<string>{"Cheese"});
                                   cart.Add(p1);
                                   num += 1;
                                   System.Console.WriteLine("Added Cheese Pizza");
                                   break;
                              case 2:
                                   var p2 = startup.CreatePizza("L", "Regular", new List<string>{"Cheese, Pepperoni"});
                                   cart.Add(p2);
                                   num += 1;
                                   System.Console.WriteLine("Added Pepperoni Pizza");
                                   break;
                              case 3:
                                   var p3= startup.CreatePizza("L", "Regular", new List<string>{"Cheese, Pineapple, Ham"});
                                   cart.Add(p3);
                                   num += 1;
                                   System.Console.WriteLine("Added Hawaiian Pizza");
                                   break;
                              case 4:
                                   var p4 = startup.CreatePizza("L", "Regular", new List<string>{"Cheese, Pepperoni, Sausage, Meatball, Bacon"});
                                   cart.Add(p4);
                                   num += 1;
                                   System.Console.WriteLine("Added Meat Lovers Pizza");
                                   break;
                              case 5:
                                   var p = startup.CreatePizza("L", "Regular", new List<string>{"Cheese, Buffalo, Chicken, Ranch"});
                                   cart.Add(p);
                                   num += 1;
                                   System.Console.WriteLine("Added Custom Pizza");
                                   break;
                              case 6:
                                   DisplayCart(cart);
                                   break;
                              case 7:
                                   System.Console.WriteLine("Exit Pizza");
                                   order = false;
                                   break;
                         }
                    }
                    else
                    {
                         order = false;
                         System.Console.WriteLine("Cart is Full");
                         DisplayCart(cart);
                    }
               } while (order);
          }

          static void DisplayCart(List<Pizza> cart)
          {
               int cnt = 1;
               foreach (var pizza in cart)
               {
                    System.Console.WriteLine("Pizza "+ cnt + ": " + pizza.ToString());
                    cnt+=1;
               }
          }
     }
}
