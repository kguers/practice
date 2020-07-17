using System;
using System.Collections.Generic;
using PizzaShop.Domain.Models;
using Xunit;

namespace PizzaShop.Testing.Tests
{
     public class OrderTest
     {
          [Theory]
          [InlineData("S","R","T")]
          [InlineData("M", "C", "T2")]
          public void Test_CreatePizza(string s, string c, string t)
          {
               //arrange
               var sut = new Order();
               string size = s;
               string style = c;
               List<string> toppings = new List<string>{t};

               //act
               sut.CreatePizza(size, style, toppings);

               //assert
               Assert.True(sut.Pizzas.Count == 1);
          }
     }
}