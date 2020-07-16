using System;
using System.Collections.Generic;
using  PizzaShop.Domains.Models;

namespace PizzaShop.Client
{
     internal class Startup
     {
          internal Pizza CreatePizza(string size, string style, List<string> toppings)
          {
               var pizza = new Pizza(size, style, toppings);
               return pizza;
          }
     }
}