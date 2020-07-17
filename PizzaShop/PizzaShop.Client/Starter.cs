using System;
using System.Collections.Generic;
using PizzaShop.Domain.Models;

namespace PizzaShop.Client
{
     public class Starter
     {
          public Order CreateOrder(User user, Store store)
          {
               try
               {
                    var order = new Order();

                    user.Orders.Add(order);
                    store.Orders.Add(order);

                    return order;
               }
               catch
               {
                    throw new System.Exception("Tech Dif");
                    //return null;
               }
               finally
               {
                    GC.Collect();
               }
         }

         internal static void PrintMenu()
         {
              System.Console.WriteLine("Select 1 for Cheese Pizza");
               System.Console.WriteLine("Select 2 for Pepperoni Pizza");
               System.Console.WriteLine("Select 3 for Hawaiian Pizza");
               System.Console.WriteLine("Select 4 for Meat Lovers Pizza");
               System.Console.WriteLine("Select 5 for Custom Pizza");
               System.Console.WriteLine("Select 6 to Save Cart");
               System.Console.WriteLine("Select 7 to Display Cart");
               System.Console.WriteLine("Select 8 for Exit Pizza");
         }
     }
}