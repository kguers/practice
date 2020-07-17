using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Domain.Models
{
     public class Pizza
     {
         //STATE
          //Fields
          private readonly string _imageUrl =  "https://some-url";
          private const double _diameter = 14;
          private static string _name = "pizza";
          private List<string> _toppings = new List<string>();

          //Properties
          public string  SizeP { get; set;}
          public string Style {get; set;}
          public List<string> Toppings 
          {
               get
               {
                    return _toppings;
               }
          }
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
               return $"{SizeP} {Style} with Toppings: {sb}";
          }
          //Constructors
          public Pizza(string size, string style, List<string> toppings)
          {
                    SizeP = size;
                    Style = style;
                    Toppings.AddRange(toppings);
          }

          public Pizza()
          {
               //intentionaly empty for serializer
          }
          //Destructors

     }
}