using System;
using System.Collections.Generic;

namespace PizzaShop.Domain.Models
{
     public class Store
     {
          public List<Order> Orders { get; }

          public Store()
          {
                 Orders = new List<Order>();
          }
     }
}