using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Domains.Models
{
     public class Pizza
     {
         //STATE
          //Fields
          public string ImageUrl = " ";
          public string Size = " ";
          public string Style= " ";
          public List<string> Toppings = new List<string>();
          //Properties
          public string  SizeP { get; }
          //BEHAVIOR
          //Methods
          void AddToppings(string topping)
          {
               Toppings.Add(topping);
          }

          public override string ToString()
          {
               var sb = new StringBuilder();
               foreach(var t in Toppings)
               {
                    sb.Append(t);
               }   
               return $"{Size} {Style} with Toppings: {sb}";
          }
          //Constructors
          public Pizza(string size, string style, List<string> toppings)
          {
                    SizeP = size;
                    Style = style;
                    Toppings.AddRange(toppings);
          }
          //Destructors

     }
}