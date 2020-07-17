using System;
using System.Collections.Generic;

namespace PizzaShop.Domain.Models
{
     public class Order
     {
          public List<Pizza> Pizzas{get;}

          public void CreatePizza(string size, string style, List<string> toppings)
          {
                Pizzas.Add(new Pizza(size, style, toppings));              
          }
          
          public Order()
          {
               Pizzas = new List<Pizza>();
          }

     }
}